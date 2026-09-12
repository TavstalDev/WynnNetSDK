# Security Policy

## Scope

WynnNetSDK is a client library for the [Wynncraft API](https://docs.wynncraft.com/welcome).
The SDK itself does not store, send, or process player data.

It only creates and sends HTTP requests to the Wynncraft API using your credentials.

Because of that, the safety of your API token and the data returned by Wynncraft depends on
Wynncraft, not on this SDK. If you think you found a security issue with the Wynncraft API or
their servers, contact Wynncraft through their official channels.

---

## Keeping your API token safe

The biggest risk when using this SDK is exposing your Wynncraft API token by accident.
Please follow these rules:

- **Never** hardcode your API token in your source code.
- **Never** commit files that contain your token to version control (like GitHub).
- Use environment variables, a secrets manager, or `dotnet user-secrets` while developing.
- Rotate your token right away if you think it was exposed.

---

## Reporting a security issue in this SDK

If you find a vulnerability in the SDK's own code (for example, if the library leaks your API
token, logs sensitive data, or handles HTTP responses in an unsafe way), report it using
[GitHub private vulnerability reporting](https://github.com/TavstalDev/WynnNetSDK/security/advisories/new)
instead of opening a public issue.

We will review every report and reply as soon as possible.

---

## Supported versions

| Version | Supported |
|---------|-----------|
| 1.0.x   | Yes       |

---

## Disclaimer

This SDK is not affiliated with or endorsed by Wynncraft.
Use it at your own risk. Read the [LICENSE](./LICENSE) file for the full terms.