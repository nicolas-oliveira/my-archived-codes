import { Test, TestingModule } from '@nestjs/testing';
import { INestApplication, BadRequestException } from '@nestjs/common';
import * as request from 'supertest';
import { AppModule } from 'src/app.module';
import PratagyController from './pratagy.controller';
import PratagyModule from './pratagy.module';
import { IsAfterToday } from 'src/validators/IsAfterToday';
import PratagyService from './pratagy.service';
import CrawlingService from '../Crawling/crawling.service';
import SearchBodyDTO from './dtos/SearchBody.dto';

const roomList = [
	{
		"name": "Studio Casal",
		"description": "No prédio principal do Resort, sem varanda e próximo à recepção. Dispõe de uma cama de casal e uma cama de solteiro. Acomoda até 2 pessoas. Sem cama extra. Inclui ingressos do Pratagy Acqua Park*. All inclusive com serviço de buffet.",
		"price": "R$ 1.209,00",
		"image": "https://letsimage.s3.amazonaws.com/letsbook/193/quartos/30/fotoprincipal.jpg"
	},
	{
		"name": "Studio Familia",
		"description": "No prédio principal do Resort, com varanda e vista para os jardins. Dispõe de uma cama de casal e uma cama de solteiro. Acomoda até 3 pessoas, nas opções de 1 adulto e 2 crianças (free até 12 anos) ou 2 adultos e 1 criança (free até 12 anos) ou 3 adultos. Sem cama extra. Inclui ingressos do Pratagy Acqua Park*. All inclusive com serviço de buffet.",
		"price": "R$ 1.330,00",
		"image": "https://letsimage.s3.amazonaws.com/letsbook/193/quartos/31/fotoprincipal.jpg"
	},
]

describe('PratagyController', () => {
  let pratagyController: PratagyController;
  let pratagyService: PratagyService;

  beforeEach(async () => {
    const moduleFixture: TestingModule = await Test.createTestingModule({
      controllers: [
        PratagyController
      ],
      providers: [
        PratagyService,
        CrawlingService
      ]
    }).compile();

    pratagyController = moduleFixture.get<PratagyController>(PratagyController);
    pratagyService = moduleFixture.get<PratagyService>(PratagyService);
  });

  it('should be defined', () => {
    expect(pratagyController).toBeDefined();
    expect(pratagyService).toBeDefined();
  });

  describe('search', () => {
    function getTodayDate() {
      return new Date().toISOString().split('T')[0];
    }      

    function getTodayDatePlusManyDays(numberOfDaysToAdd: number) {
      const someDate = new Date();
      const result = someDate.setDate(someDate.getDate() + numberOfDaysToAdd);
      return new Date(result).toISOString().split('T')[0];
    }

    const body: SearchBodyDTO = {
      checkin: getTodayDate(),
      checkout: getTodayDatePlusManyDays(4),
    };

    it('should return the result of a Room List', async () => {
      jest.spyOn(pratagyService, 'handleSearch').mockResolvedValueOnce(roomList);

      const result = await pratagyController.search(body);

      expect(result).toEqual(roomList);
    });
  });
});
