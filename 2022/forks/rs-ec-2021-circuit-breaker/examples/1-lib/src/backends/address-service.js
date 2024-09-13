const Router = require("koa-router");

const { startServer, delay } = require("../utils");

const ADDRESS = {
  addressLine1: "57 Rua Ipatinga",
  addressLine2: "Casa",
  state: "MG",
  city: "Passos",
  country: "Brasil",
  zipCode: "37904-222",
};

const router = new Router();

const getAddress = (ctx) =>
  delay(parseInt(process.env.FORCED_DELAY || 100)).then(
    () => (ctx.body = ADDRESS)
  );

router.get("/address", getAddress);

startServer(router, "/api", process.env.PORT);
