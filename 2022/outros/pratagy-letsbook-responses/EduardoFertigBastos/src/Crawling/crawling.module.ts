import { Module } from '@nestjs/common';
import CrawlingService from './crawling.service';

@Module({
  imports: [
  ],
  controllers: [
  ],
  providers: [
    CrawlingService,
  ],
})
export default class CrawlingModule {}
