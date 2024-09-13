import jwt from 'jsonwebtoken';
import * as yup from 'yup';

import User from '../models/User';
import authConfig from '../../config/auth';

class SessionController {
  async store(request, response) {
    const schema = yup.object().shape({
      email: yup.string().email().required(),
      password: yup.string().required(),
    });

    if (!(await schema.isValid(request.body))) {
      return response.status(400).json({ error: 'Validation fails' });
    }

    const { email, password } = request.body;

    const user = await User.findOne({ where: { email } });
    if (!user) {
      return response.status(401).json({ error: 'User not found' });
    }
    if (!(await user.checkPassword(password))) {
      return response.status(401).json({ error: 'Password does not match' });
    }

    const { id, name } = user;

    return response.json({
      user: {
        id,
        name,
        email,
      },
      // developmentquemestudaehquemvence5 => md5 online
      token: jwt.sign({ id }, authConfig.secret, {
        expiresIn: authConfig.expiresIn,
      }),
    });
  }
}
export default new SessionController();
