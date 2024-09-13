// Filtre o seguinte json para que apareça dessa forma:
// errors: [
//		{
//			"Name": {"Name do not be empty"}
//		},
//		{
//			"Email": "Email do not be empty"
//		}
//	];
const json = {
    "errors": [
        {
         "message": "Email can't be empty",
         "type": "Validation error",
         "path": "email",
         "value": "",
         "origin": "FUNCTION",
         "instance": {
          "id": 21,
          "name": "Nicolas Fodão",
          "email": "",
          "password_hash": "$2a$08$xbwqzHXL0ZgSl5KXt/CxkuODxIaEa.oCM6egjo5P6WGcYahTUGqQ6",
          "createdAt": "2020-06-03T12:31:54.561Z",
          "updatedAt": "2020-06-08T18:22:49.036Z"
         },
         "validatorKey": "notEmpty",
         "validatorName": "notEmpty",
         "validatorArgs": [
          {
           "msg": "Email can't be empty"
          }
         ],
         "original": {
          "validatorName": "notEmpty",
          "validatorArgs": [
           {
            "msg": "Email can't be empty"
           }
          ]
         }
        },
        {
         "message": "Incorrect format for the email field",
         "type": "Validation error",
         "path": "email",
         "value": "",
         "origin": "FUNCTION",
         "instance": {
          "id": 21,
          "name": "Nicolas Fodão",
          "email": "",
          "password_hash": "$2a$08$xbwqzHXL0ZgSl5KXt/CxkuODxIaEa.oCM6egjo5P6WGcYahTUGqQ6",
          "createdAt": "2020-06-03T12:31:54.561Z",
          "updatedAt": "2020-06-08T18:22:49.036Z"
         },
         "validatorKey": "isEmail",
         "validatorName": "isEmail",
         "validatorArgs": [
          {
           "msg": "Incorrect format for the email field",
           "allow_display_name": false,
           "require_display_name": false,
           "allow_utf8_local_part": true,
           "require_tld": true
          }
         ],
         "original": {
          "validatorName": "isEmail",
          "validatorArgs": [
           {
            "msg": "Incorrect format for the email field",
            "allow_display_name": false,
            "require_display_name": false,
            "allow_utf8_local_part": true,
            "require_tld": true
           }
          ]
         }
        }
       ]
}
const newarr = json.errors.filter((e) =>{
	return {path: e.path, message: e.message};
})
console.log({errors: newarr});


