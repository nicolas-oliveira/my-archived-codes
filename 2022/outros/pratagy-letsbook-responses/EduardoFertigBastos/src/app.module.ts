import { Module } from '@nestjs/common';
import PratagyModule from './Pratagy/pratagy.module';

@Module({
  imports: [
    PratagyModule
  ],
  controllers: [
  ],
  providers: [
  ],
})
export class AppModule {}
