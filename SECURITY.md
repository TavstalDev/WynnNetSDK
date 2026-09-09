# Security Policy

## Scope

WynnNetSDK is a client library for the [Wynncraft API](https://docs.wynncraft.com/welcome).
The SDK itself does not store, transmit, or process player data directly.
Instead, it creates and sends HTTP requests to Wynncraft's API servers using your credentials.

Because of this, the safety of your actual API token and any data returned by Wynncraft
depends on Wynncraft, not this SDK. If you believe you have found a security issue with
the Wynncraft API or their servers, please contact Wynncraft through their official channels.

---

## Keeping Your API Token Safe

The biggest security risk when using this SDK is accidentally exposing your Wynncraft API token.
Please follow these rules:

- **Never** hardcode your API token directly into your source code.
- **Never** commit files containing your token to version control (like GitHub).
- Use environment variables, a secrets manager, or `dotnet user-secrets` during development.
- Rotate your token immediately if you suspect it has been exposed.

---

## Reporting a Security Issue in This SDK

If you find a security vulnerability in the SDK's own code (for example, if the library
leaks your API token, logs sensitive data, or mishandles HTTP responses in a way that could
lead to a security issue), please report it using
[GitHub private vulnerability reporting](https://github.com/TavstalDev/WynnNetSDK/security/advisories/new)
instead of opening a public issue.

We will review every report and respond as quickly as possible.

---

## Supported Versions

| Version | Supported |
|---------|-----------|
| 1.0.x   | Yes       |

---

## Disclaimer

This SDK is not affiliated with, endorsed by, or connected to Wynncraft.
Use it at your own risk. Please read the [LICENSE](./LICENSE) file for full terms.
