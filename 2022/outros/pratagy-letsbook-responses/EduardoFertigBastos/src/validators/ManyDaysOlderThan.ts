import { ValidationArguments, ValidationOptions, ValidatorConstraint, ValidatorConstraintInterface, registerDecorator } from 'class-validator';

@ValidatorConstraint({ name: 'ManyDaysOlderThan' })
class ManyDaysOlderThanValidator implements ValidatorConstraintInterface {
  validate(date: string, args: ValidationArguments) {
    const manyDays = args.constraints[0];
    const relatedDate = (args.object as any)[args.constraints[1]];

    if (!relatedDate) {
      return false;
    }
    
    return isSecondDateManyDaysAfterFirstDate(date, relatedDate, manyDays);
  }
}

function isSecondDateManyDaysAfterFirstDate(date: string, relatedDate: string, manyDays: number): boolean {
  const dateObj = new Date(date);
  const relatedDateObj = new Date(relatedDate);
  
  const diffInDays = Math.round(
    (dateObj.getTime() - relatedDateObj.getTime()) 
    / (1000 * 60 * 60 * 24)
  );

  return diffInDays >= manyDays;
}

export function ManyDaysOlderThan(days: number, property: string,  validationOptions?: ValidationOptions) {
  return function (object: object, propertyName: string) {
    registerDecorator({
      name: 'ManyDaysOlderThan',
      target: object.constructor,
      propertyName: propertyName,
      constraints: [days, property],
      options: {
        message: `The ${propertyName} must be at least ${days} days later than the ${property}`,
        ...validationOptions,
      },
      validator: ManyDaysOlderThanValidator,
    });
  };
}
