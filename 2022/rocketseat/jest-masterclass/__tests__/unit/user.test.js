const bcrypt = require("bcryptjs");
const { User } = require("../../src/models");
const truncate = require("../utils/truncate");

describe("User", () => {
	beforeEach(async () => {
		await truncate();
	});

	it("Deve encriptar a senha do usuário", async () => {
		const user = await User.create({
			name: "Nicolas",
			email: "nicolas@hotmail.com",
			password: "senha maluca",
		});

		// const hash = await bcrypt.hash("senha maluca", 8);

		expect(
			await bcrypt.compare("senha maluca", user.password_hash)
		).toBe(true);
	});
});
