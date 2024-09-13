import { Router } from 'express';

import AdmController from './controllers/AdmController';
import SessionController from './controllers/SessionController';
import RecipientController from './controllers/RecipientController';

import authMiddleware from './middlewares/auth';

import './database';

const routes = new Router(); // ? precisa do new o que é?
// controllers

routes.post('/adm', AdmController.store);
routes.put('/adm', authMiddleware, AdmController.update);

routes.post('/session', SessionController.store);

routes.post('/recipient', authMiddleware, RecipientController.store);
routes.put('/recipient/:id', authMiddleware, RecipientController.update);


export default routes;
