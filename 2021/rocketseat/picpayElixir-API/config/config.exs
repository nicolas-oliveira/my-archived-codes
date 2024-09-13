# This file is responsible for configuring your application
# and its dependencies with the aid of the Mix.Config module.
#
# This configuration file is loaded before any dependency and
# is restricted to this project.

# General application configuration
use Mix.Config

config :picpayElixir,
  ecto_repos: [PicpayElixir.Repo]

# Configures the endpoint
config :picpayElixir, PicpayElixirWeb.Endpoint,
  url: [host: "localhost"],
  secret_key_base: "eoeOWMkD4JKqb+iGAdkEo/S5Y7o5QO4zu+hfDFfXmzSJSC0dCBeloXQbBtvTpu48",
  render_errors: [view: PicpayElixirWeb.ErrorView, accepts: ~w(json), layout: false],
  pubsub_server: PicpayElixir.PubSub,
  live_view: [signing_salt: "9yAawA5m"]

config :picpayElixir, PicpayElixir.Repo,
  migration_primary_key: [type: :binary_id],
  migration_foreign_key: [type: :binary_id]

# Configures Elixir's Logger
config :logger, :console,
  format: "$time $metadata[$level] $message\n",
  metadata: [:request_id]

# Use Jason for JSON parsing in Phoenix
config :phoenix, :json_library, Jason

# Import environment specific config. This must remain at the bottom
# of this file so it overrides the configuration defined above.
import_config "#{Mix.env()}.exs"
