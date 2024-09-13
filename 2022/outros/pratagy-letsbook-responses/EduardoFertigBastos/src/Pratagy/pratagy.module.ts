import { Module } from '@nestjs/common';
import CrawlingModule from '../Crawling/crawling.module';
import CrawlingService from '../Crawling/crawling.service';
import PratagyController from './pratagy.controller';
import PratagyService from './pratagy.service';

@Module({
  imports: [
    CrawlingModule,
  ],
  controllers: [
    PratagyController,
  ],
  providers: [
    PratagyService,
    CrawlingService
  ],
})
export default class PratagyModule {}
