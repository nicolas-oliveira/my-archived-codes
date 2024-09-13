const request = require('supertest');
const app = require('../../src/app');
const connection = require('../../src/database/connection');

describe('ONG', () => {
    beforeEach(async () => {
        await connection.migrate.latest();
    });
    
    afterAll(async () => {
        await connection.destroy();
    });

    it('should be able to create a new ONG', async () => {
        const response = await request(app)
            .post('/ongs')
            .send({
                name: "Cachorros e CIA",
                email: "nicolasm15@hotmail.com.br",
                whatsapp: "3511111111",
                city: "Rio de Janeiro",
                uf: "RJ"
            });
            console.log(response.body);
    });
});