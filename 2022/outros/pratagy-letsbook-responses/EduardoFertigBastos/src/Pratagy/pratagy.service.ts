import { BadRequestException, Injectable } from '@nestjs/common';
import RoomDTO from './dtos/Room.dto';
import handleTextRetiredFromHtml from '../helpers/handleTextRetiredFromHtml';
import CrawlingService from '../Crawling/crawling.service';

interface SearchProps {
  checkin: string;
  checkout: string;
}

@Injectable()
export default class PratagyService  {
  constructor(private readonly crawlingService: CrawlingService) {}
  
  baseURL = 'https://pratagy.letsbook.com.br';
  otherQueryParams = 'hotel=12&adultos=2&destino=Pratagy+Beach+Resort+All+Inclusive';

  async handleSearch({ checkin, checkout }: SearchProps) {
    const url = this.buildURLBasedOnCheckinCheckout({ checkin, checkout });
    
    await this.crawlingService.preparePageToExtractData({ url });
    
    await this.checkAvailabiltyByMinimumDaysPerStay();
    
    await this.waitUntilRoomsAreLoaded()

    const rooms = await this.getAvailableRooms();
    
    return rooms;
  }

  async waitUntilRoomsAreLoaded() {
    await this.crawlingService.page.waitForSelector('.row-quarto .slick-current');
  }

  async getAvailableRooms() {
    const availableRooms = await this.crawlingService.page.evaluate(() => {

      function handleTextUnformattedFromHtml(text: string) {
        return text.replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
      }

      function getFormattedRoom(roomHtml: Element): RoomDTO {
        return ({
          name: getName(roomHtml),
          description:  getDescription(roomHtml),
          price: getPrice(roomHtml),
          image: getImage(roomHtml),
        });
      }
    
      function getName(roomHtml: Element): string {
        const nameTextUnformatted = roomHtml
          .querySelector('.quartoNome')
          .textContent;
        
        const nameTextFormatted = handleTextUnformattedFromHtml(nameTextUnformatted);

        return nameTextFormatted;
      }
    
      function getDescription(roomHtml: Element): string {
        const descriptionTextUnformatted = roomHtml
          .querySelector('.quartoDescricao > p')
          .textContent;
        
        const descriptionTextFormatted = handleTextUnformattedFromHtml(descriptionTextUnformatted);

        return descriptionTextFormatted;
      }
    
      function getPrice(roomHtml: Element): string {
        const priceTextUnformatted = roomHtml
          .querySelector('.valorFinal.valorFinalDiscounted')
          .textContent;

        const priceFormatted = handleTextUnformattedFromHtml(priceTextUnformatted)
        
        return priceFormatted;
      }
    
      function getImage(roomHtml: Element): string {
        const image = roomHtml.querySelector<HTMLElement>('.slick-current')
          ?.style
          .backgroundImage;

        const modifiedImage = image.substring(5, image.length - 2)
        
        return modifiedImage;
      }

      
      const roomsHtml = document.querySelectorAll('.row-quarto');
      const roomsArray = [...roomsHtml];

      const roomsFormatted = roomsArray.map(room => getFormattedRoom(room));

      return roomsFormatted;
    });

    return availableRooms;
  }


  async hasAvailableHotel() { 
    try {
      await this.crawlingService.page.waitForSelector('#hotel-selecionado-indisponivel', {
        timeout: 5000
      }); 

      return false;
    } catch (error) {
      return true;
    }
  }

  async getMinimunDaysError() {
    const warningMinimumDaysText = await this.crawlingService.page.evaluate(() => {
      const warningMinimumDaysText = document
        .querySelector('.hotel-selecionado-indisponivel-titulo')
        .textContent

      return warningMinimumDaysText;
    });

    const errorTextHandled = handleTextRetiredFromHtml(warningMinimumDaysText);

    return errorTextHandled;
  }

  async checkAvailabiltyByMinimumDaysPerStay() {
    if (await this.hasAvailableHotel()) {
      return;
    }
    
    const errorTextHandled = await this.getMinimunDaysError();

    throw new BadRequestException(errorTextHandled);
  }
  
  buildURLBasedOnCheckinCheckout({ checkin, checkout }: SearchProps) {
    const url = `${this.baseURL}/D/Reserva?checkin=${checkin}&checkout=${checkout}&${this.otherQueryParams}`;

    return url;
  }

}
