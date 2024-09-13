const { it, expect } = require("@jest/globals");
const request = require("supertest");

const app = require("../../src/app");
const truncate = require("../utils/truncate");
const factory = require("../factories");

describe("Autenticação", () => {
	beforeEach(async () => {
		await truncate();
	});

	it("Deve autenticar com credenciais válidas", async () => {
		const user = await factory.create("User");
		console.log(user);
		const response = await request(app).post("/sessions").send({
			email: user.email,
			password: user.password,
		});

		expect(response.status).toBe(200);
	});

	it("não pode se autenticar com credenciais inválidas", async () => {
		const user = await factory.create("User");

		const response = await request(app).post("/sessions").send({
			email: user.email,
			password: "wrongPassword",
		});

		expect(response.status).toBe(401);
	});

	it("Deve retornar um JWT quando autenticado", async () => {
		const user = await factory.create("User");

		const response = await request(app).post("/sessions").send({
			email: user.email,
			password: user.password,
		});

		expect(response.body).toHaveProperty("token");
	});

	it("Deve ser capaz de acessar rotas privadas quando autenticado", async () => {
		const user = await factory.create("User");

		const response = await request(app)
			.get("/dashboard")
			.set("Authorization", `Bearer ${user.generateToken()}`);

		expect(response.status).toBe(200);
	});

	it("Não pode ser capaz de acessar rotas privadas sem se autenticar", async () => {
		const response = await request(app).get("/dashboard");

		expect(response.status).toBe(401);
	});

	it("Não pode ser capaz de acessar rotas privadas com token inválido", async () => {
		const response = await request(app)
			.get("/dashboard")
			.set("Authorization", `Bearer 6273458901gdf28@`);

		expect(response.status).toBe(401);
	});
});
