import { Test, TestingModule } from "@nestjs/testing";
import PratagyService from "./pratagy.service";
import CrawlingService from "../Crawling/crawling.service";
import { BadRequestException } from "@nestjs/common";

describe('PratagyService', () => {
  let pratagyService: PratagyService;
  let crawlingService: CrawlingService;

  beforeEach(async () => {
    const mockCrawlingService = {
      preparePageToExtractData: jest.fn(),
      page: {
        waitForSelector: jest.fn(),
        evaluate: jest.fn()
      }
    };

    const moduleRef: TestingModule = await Test.createTestingModule({
      providers: [
        PratagyService,
        {
          provide: CrawlingService,
          useValue: mockCrawlingService
        }
      ],
    }).compile();

    pratagyService = moduleRef.get<PratagyService>(PratagyService);
    crawlingService = moduleRef.get<CrawlingService>(CrawlingService);
  });

  it("should be defined", () => {
    expect(pratagyService).toBeDefined();
  })

  describe("waitUntilRoomsAreLoaded", () => {
    it("should call waitForSelector with correct arguments", async () => {
      jest.spyOn(crawlingService.page, "waitForSelector").mockResolvedValue(null);

      await pratagyService.waitUntilRoomsAreLoaded();

      expect(crawlingService.page.waitForSelector).toHaveBeenCalledWith(".row-quarto .slick-current");
    });
    
  });

  describe("hasAvailableHotel", () => {
    it("should return false if hotel is not available", async () => {
      jest.spyOn(crawlingService.page, "waitForSelector").mockResolvedValue(null);

      const hasAvailableHotel = await pratagyService.hasAvailableHotel();

      expect(hasAvailableHotel).toBe(false);
    });
  });

  describe("checkAvailabiltyByMinimumDaysPerStay", () => {
    it("should throw BadRequestException if hotel is not available", async () => {
      jest.spyOn(pratagyService, "hasAvailableHotel").mockResolvedValue(false);

      jest.spyOn(pratagyService, "getMinimunDaysError").mockResolvedValue("Minimum days error message");

      await expect(pratagyService.checkAvailabiltyByMinimumDaysPerStay()).rejects.toThrow(BadRequestException);
    });

    it("should not throw BadRequestException if hotel is available", async () => {
      jest.spyOn(pratagyService, "hasAvailableHotel").mockResolvedValue(true);

      jest.spyOn(pratagyService, "getMinimunDaysError");

      await expect(pratagyService.checkAvailabiltyByMinimumDaysPerStay()).resolves.not.toThrow(BadRequestException);
    });
  });

  describe("buildURLBasedOnCheckinCheckout", () => {
    it("should return correct URL", async () => {
      expect(
        pratagyService.buildURLBasedOnCheckinCheckout({
          checkin: "10/12/2021",
          checkout: "12/12/2021"
        })
      ).toEqual("https://pratagy.letsbook.com.br/D/Reserva?checkin=10/12/2021&checkout=12/12/2021&hotel=12&adultos=2&destino=Pratagy+Beach+Resort+All+Inclusive");
    });
  });
});
