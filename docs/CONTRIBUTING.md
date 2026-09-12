# Contributing to WynnNetSDK

Thank you for your interest in helping with this project. This guide explains how to contribute.

---

## How to contribute

1. **Fork** the repository on GitHub.
2. **Clone** your fork to your computer.
3. Create a **new branch** for your work:
   ```bash
   git checkout -b feature/my-new-feature
   ```
4. Make your changes.
5. **Test** your changes (see [Testing](#testing)).
6. **Commit** your changes with a clear message.
7. **Push** your branch and open a **pull request** (PR).

---

## Development setup

Requirements:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or newer
- A code editor (Visual Studio, Rider, VS Code, etc.)

Build the solution:

```bash
dotnet build WynnNetSDK.sln
```

Run the tests:

```bash
dotnet test WynnNetSDK.sln
```

---

## Testing

The project has a test project: `WynnNetSdk.Tests`. Please follow these rules:

- Add tests for every new feature or bug fix.
- Put tests in files that clearly describe what they test.
- Run all tests before you open a pull request.

---

## Code style

Please follow the existing style in the project:

- Use the same naming conventions as the rest of the code.
- Use file-scoped namespaces.
- Enable `nullable` and `implicit usings` (they are already on).
- Do **not** add comments unless they explain something non-obvious.
- Keep methods small and focused.

If you are unsure, look at similar files in the same folder for examples.

---

## How the code is organized

The solution has two projects:

- **WynnNetSDK** — the library.
  - `Http/Clients/` — the public client classes (Player, Guild, Items, etc.).
  - `Http/Requests/` — one request class per HTTP endpoint.
  - `Models/` — the data models for the API responses.
  - `Serialization/` — source-generated JSON serialization (`WynnSdkJsonContext`).
  - `Caching/` — the `ICacheManager` interface.
- **WynnNetSdk.Tests** — the test project.

### Adding a new endpoint

1. Create a request class in `Http/Requests/<Area>/` that inherits from `HttpRequestBase<T>`.
2. Add the return model in `Models/` if it does not exist yet.
3. If the model is new, register it in
   `Serialization/WynnSdkJsonContext.cs` with a `[JsonSerializable]` attribute.
4. Add a method to the matching client in `Http/Clients/`.
5. Add a test for the new method.

> **Important**: if your new request uses a body (`POST`), the body type must be registered in the
> JSON context, just like the response models.

---

## Commit messages

Use short, clear commit messages. We follow the **Conventional Commits** style:

- `feat: add new endpoint for ...`
- `fix: correct the retry logic in ...`
- `docs: update the API reference ...`
- `refactor: clean up ...`
- `test: add tests for ...`

---

## Pull requests

Before you open a pull request, please check:

- [ ] The code builds without errors.
- [ ] All tests pass.
- [ ] New public methods are documented in the API reference (`docs/API_REFERENCE.md`).
- [ ] No secrets or tokens are committed.
- [ ] The branch is up to date with `master`.

---

## AI usage

This policy applies to pull requests from external contributors.

- **AI-generated documentation** — accepted, as long as a human reviews it.
- **AI-generated code** — not accepted. This means code written in bulk by an AI, like a whole
  method or file pasted from a chatbot.
- **AI-suggested fixes** — these are in the gray zone. A suggestion is a small edit, like inline
  autocomplete or a short fix (up to roughly one method). A human must review it and test it before
  merging.
- **Gray-zone disclosure** — if your pull request contains gray-zone fixes, mention it in the PR
  description so reviewers know what to check closely.
- **Testing** — gray-zone fixes are only mergeable when the full test suite passes. Please add a
  new test when it makes sense.

---

## Questions?

If you need help, open an [issue](https://github.com/TavstalDev/WynnNetSDK/issues) and ask.