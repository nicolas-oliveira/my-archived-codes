import { ValidationOptions, ValidatorConstraint, ValidatorConstraintInterface, registerDecorator } from 'class-validator';

@ValidatorConstraint({ name: 'IsAfterToday' })
class IsAfterTodayValidator implements ValidatorConstraintInterface {
  validate(date: string) {
    const dateObj = new Date(date);
    const relatedDateObj = new Date();
    
    const diffInDays = Math.round(
      (dateObj.getTime() - relatedDateObj.getTime()) 
      / (1000 * 60 * 60 * 24)
    );

    return diffInDays >= 0;
  }
}

export function IsAfterToday(validationOptions?: ValidationOptions) {
  return function (object: object, propertyName: string) {
    registerDecorator({
      target: object.constructor,
      propertyName: propertyName,
      options: {
        message: `The ${propertyName} date can not be earlier than today`,
        ...validationOptions,
      },
      validator: IsAfterTodayValidator,
    });
  };
}
