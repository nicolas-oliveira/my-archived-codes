import { Body, Controller, Post } from '@nestjs/common';
import SearchBodyDTO from './dtos/SearchBody.dto';
import PratagyService from './pratagy.service';

@Controller()
export default class PratagyController {
  constructor(private readonly pratagyService: PratagyService) {}

  @Post('search')
  async search(
    @Body() 
    body: SearchBodyDTO
  ) {
    const { checkin, checkout } = body;

    const result = await this.pratagyService.handleSearch({ checkin, checkout });

    return result;
  }
}
