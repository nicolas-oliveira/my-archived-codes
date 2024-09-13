# Test Dev Asksuite



## [POST] /search:
In the application there is a route [POST] /search, 
which the expected payload is:
    
                {
                    "checkin": "YYYY-MM-DD", // Check-in date
                    "checkout": "YYYY-MM-DD" // Check-out date
                }

The checkin date must be before the checkout date, and the checkin date must also be either the current day or after the current day


        
In case of success it will return an array with the following data format
    
                [
                    {
                        "name": "STUDIO CASAL",
                        "description": "Apartamentos localizados no prédio principal do Resort, próximos a recepção e a área de convivência, com vista para área de estacionamento não possuem varanda. Acomoda até 1 adulto e 1 criança ou 2 adultos", 
                        "price": "R$ 1.092,00",
                        "image": "https://letsimage.s3.amazonaws.com/letsbook/193/quartos/30/fotoprincipal.jpg"
                    },
                    {
                        "name": "CABANA",
                        "description": "Apartamentos espalhados pelos jardins do Resort, com vista jardim possuem varanda. Acomoda até 4 adultos ou 3 adultos e 1 criança ou 2 adultos e 2 criança ou 1 adulto e 3 crianças, em duas camas casal.", 
                        "price": "R$ 1.321,00",
                        "image": "https://letsimage.s3.amazonaws.com/letsbook/193/quartos/32/fotoprincipal.jpg"
                    }
                ]
        
but it can return an error like this depending of the hotel schedules

                {
                    "statusCode": 400,
                    "message": "Para você fazer checkin no dia 01/04/2023, é necessário permanecer no mínimo 3 noite(s)",
                    "error": "Bad Request"
                }


To install the dependencies use

                npm install

To run the application, use

                npm run start:dev


To run the tests, you can use the following commands to test the PratagyController, 

                npm run test:watch -t src\Pratagy\pratagy.controller.spec.ts

and the PratagyService

                npm run test:watch -t src\Pratagy\pratagy.service.spec.ts