import Recipient from '../models/Recipient';
import Adm from '../models/Adm';

module.exports = {
	async store(request, response) {
		try {
			const adressExists = await Recipient.findOne({ where: { zip_code: request.body.zip_code } });

			if(adressExists) {
				return response.status(400).json({ error: 'Adress already exists.' });
			}

			const { adm_id } = request;

			const { name, number, street, city, state, country, zip_code } = request.body;

			const adress = await Recipient.create({
				name,
				number,
				street,
				city,
				state,
				country,
				zip_code,
				adm_id
			});

			return response.json(adress);

		} catch (err) {

			const messages = err.errors.map((e) =>{
				return { path: e.path, message: e.message };
			});

			return response.status(400).json({ errors: messages })
		}
	},

	async update(request, response) {
		try {
			const { id } = request.params;

			const recipient = await Recipient.findOne({ where: { id } });

			const { adm_id } = request;

			await recipient.update({ adm_id });

			const adress = await recipient.update(request.body);

			return response.json({ adress });

		} catch (err) {

				const messages = err.errors.map((e) =>{
					return { path: e.path, message: e.message };
				});

				return response.status(400).json({ errors: messages })
			}
		}
};
