import { Injectable } from '@nestjs/common';
import puppeteer, { Browser, Page } from 'puppeteer';

interface  PreparePageToExtractDataProps {
  url: string;
  waitForSelector?: string;
}

@Injectable()
export default class CrawlingService {

  browser: Browser;
  page: Page;

  async launchBrowser() {
    this.browser = await puppeteer.launch();

    return this.browser;
  }

  async preparePageToExtractData({ url, waitForSelector }:PreparePageToExtractDataProps) {
    
    await this.launchBrowser();
    
    const page = await this.browser.newPage();
    await page.goto(url);
    await page.setViewport({ width: 1080, height: 1024 });

    if (waitForSelector) {
      await page.waitForSelector(waitForSelector);
    }

    this.page = page;

    return this.page;
  }

}
