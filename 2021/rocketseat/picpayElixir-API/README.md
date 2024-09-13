# PicpayElixir

Prototype of a bank transfer API which is simulated with Phoenix and Elixir

## How To:

To start your Phoenix server:

- Install dependencies with `mix deps.get`
- Create and migrate your database with `mix ecto.setup`
- Start Phoenix endpoint with `mix phx.server`
  Now you can visit [`localhost:4000`](http://localhost:4000) from your browser.

To create this repository from scratch:

- Create BD postgres `docker-compose up`
- Install phoenix `mix archive.install hex phx_new 1.5.7`
- Create a new project `mix phx.new picpayElixir --no-webpack --no-html`
- Create migrations inside database `mix ecto.setup`
- Install extensions in VSCODE:
  - ElixirLS: Elixir support and debugger
  - ElixirLinter
- Edit `mix.exs` file inside `deps` function and add this line:
  - `{:credo, "~> 1.5", only: [:dev, :test], runtime: false}`
- Install all dependecies `mix deps.get`
- Create credo configuration file `mix credo gen.config`
- Change `.credo.exs` file in this line:
  - `{Credo.Check.Readability.ModuleDoc, false},`
    So you have all your own repository!

### Hello World in Elixir

- Add inside `router.ex`

  ```elixir
  scope "/api", PicpayElixirWeb do
    pipe_through :api

    get "", WelcomeController, :index
  end
  ```

- Create the new controller `welcome_controller` inside `controllers` folder:

  ```elixir
  defmodule PicpayElixirWeb.WelcomeController do
    use PicpayElixirWeb, :controller

    def index(conn, _params) do
      text(conn, "Welcome to the Jungle!")
    end
  end
  ```

- Acess in `http://localhost:4000/api`

- Interative Elixir inside project `iex -S mix`

Ready to run in production? Please [check our deployment guides](https://hexdocs.pm/phoenix/deployment.html).

## Learn more

- Official website: https://www.phoenixframework.org/
- Guides: https://hexdocs.pm/phoenix/overview.html
- Docs: https://hexdocs.pm/phoenix
- Forum: https://elixirforum.com/c/phoenix-forum
- Source: https://github.com/phoenixframework/phoenix
