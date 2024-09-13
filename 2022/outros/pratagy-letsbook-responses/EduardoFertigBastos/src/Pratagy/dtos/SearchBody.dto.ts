import { IsDateString } from "class-validator";
import { IsBeforeDate } from "class-validator-date";
import { IsAfterToday } from "../../validators/IsAfterToday";

export default class SearchBodyDTO {
    @IsAfterToday()
    @IsBeforeDate('checkout')
    checkin: string;

    @IsDateString()
    checkout: string;
}
