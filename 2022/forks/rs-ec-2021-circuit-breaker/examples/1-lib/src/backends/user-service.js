const Router = require("koa-router");

const { delay, startServer } = require("../utils");

const USER = {
  id: "3f548be0-bda9-482e-bce3-4a7379c0c19a",
  firstName: "Nicolas",
  lastName: "Oliveira Mariano",
  birthDate: "1998-03-22",
};

const getUser = (ctx) =>
  delay(parseInt(process.env.FORCED_DELAY || 100)).then(
    () => (ctx.body = USER)
  );

const router = new Router().get("/user", getUser);

startServer(router, "/api", process.env.PORT);
