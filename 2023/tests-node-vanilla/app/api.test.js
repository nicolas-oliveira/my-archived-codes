import { describe, before, after, it } from "node:test";
import { deepStrictEqual, ok, strictEqual } from "assert";

const BASE_URL = "http://localhost:3000";

describe("API login with JWT", () => {
  let _server = {};

  before(async () => {
    _server = (await import("./api.js")).api;

    await new Promise((resolve) => _server.once("listening", resolve));
  });

  after((done) => _server.close(done));

  it("should receive not authorized given wrong user and password", async () => {
    const data = {
      user: "nicolas",
      password: "",
    };

    const request = await fetch(`${BASE_URL}/login`, {
      method: "POST",
      body: JSON.stringify(data),
    });

    strictEqual(request.status, 401);
    const response = await request.json();

    deepStrictEqual(response, { error: "user invalid!" });
  });

  it("should login successfully given user and passwork", async () => {
    const data = {
      user: "nicolas",
      password: "123",
    };

    const request = await fetch(`${BASE_URL}/login`, {
      method: "POST",
      body: JSON.stringify(data),
    });

    strictEqual(request.status, 200);
    const response = await request.json();
    ok(response.token, "token should be present");
  });

  it("should not be allowed to acess data without a token", async () => {
    const data = {
      user: "nicolas",
      password: "123",
    };

    const request = await fetch(`${BASE_URL}/`, {
      method: "POST",
      headers: {
        authorization: "",
      },
    });

    strictEqual(request.status, 400);

    const response = await request.json();
    deepStrictEqual(response, { error: "invalid token!" });
  });
});
