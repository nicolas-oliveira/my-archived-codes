import { once } from "node:events";
import { createServer } from "node:http";
import JWT from "jsonwebtoken";

const DEFAULT_USER = {
  user: "nicolas",
  password: "123",
};

const JWT_KEY = "=Z8~72R5e6Oy+j6~j;ov";

async function loginRoute(request, response) {
  const { user, password } = JSON.parse(await once(request, "data"));

  if (user !== DEFAULT_USER.user || password !== DEFAULT_USER.password) {
    response.writeHead(401);
    response.end(JSON.stringify({ error: "user invalid!" }));
    return;
  }

  const token = JWT.sign({ user, message: "hey" }, JWT_KEY);

  response.end(JSON.stringify({ token }));
}

function isHeadersValid(headers) {
  console.log({ headers });
}

async function handler(request, response) {
  if (request.url === "/login" && request.method === "POST") {
    return loginRoute(request, response);
  }
  if (isHeadersValid(request.headers)) {
    response.writeHead(400);
    return response.end(JSON.stringify({ result: "invalid token!" }));
  }
  response.end("Olá mundo");
}

const api = createServer(handler).listen(3000, () =>
  console.log("listening at port 3000")
);

export { api };
