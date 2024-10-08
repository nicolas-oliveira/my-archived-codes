import { Request, Response } from 'express';
import { getRepository } from 'typeorm';
import * as yup from 'yup';

import Orphanage from '../models/Orphanage';
import opharnageView from '../views/orphanages_view';

export default {
  // List all
  async index(request: Request, response: Response) {
    const orphanagesRepository = getRepository(Orphanage);

    const orphanages = await orphanagesRepository.find({
      relations: ['images']
    });

    return response.json(opharnageView.renderMany(orphanages));
  },

  // List one
  async show(request: Request, response: Response) {
    const { id } = request.params;

    const orphanagesRepository = getRepository(Orphanage);

    const orphanage = await orphanagesRepository.findOneOrFail(id, {
      relations: ['images']
    });

    return response.json(opharnageView.render(orphanage));
  },
  
  async create(request: Request, response: Response) {
    const {
      name,
      latitude,
      longitude,
      about,
      instructions,
      opening_hours,
      open_on_weekends,
    } = request.body;
  
    const orphanagesRepository = getRepository(Orphanage);

    const requestImages = request.files as Express.Multer.File[]; // explicity type for multi files
   
    const images = requestImages.map(image => {
      return { path: image.filename };
    });
   
    const data = {
      name,
      latitude,
      longitude,
      about,
      instructions,
      opening_hours,
      open_on_weekends: open_on_weekends === 'true',
      images
    };

    const schema = yup.object().shape({
      name: yup.string().required(),
      latitude: yup.number().required(),
      longitude: yup.number().required(),
      about: yup.string().required().max(200),
      instructions: yup.string().required(),
      opening_hours: yup.string().required(),
      open_on_weekends: yup.boolean().required(),
      images: yup.array(
        yup.object().shape({
          path: yup.string().required()
        })
      ),
    });

    await schema.validate(data, {
      abortEarly: false,
    });

    const orphanage = orphanagesRepository.create(data);
  
    await orphanagesRepository.save(orphanage);

    return response.status(201).json(orphanage);
  }
}