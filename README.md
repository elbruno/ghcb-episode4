# ghcb-episode4

## Getting Started with .NET 9 and Aspire

To get started with this project, you need to have .NET 9 and Aspire installed on your machine.

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Aspire](https://aspire.com/download)

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/ghcb-episode4.git
    cd ghcb-episode4
    ```

2. Install the required packages:
    ```sh
    dotnet restore
    ```

## Testing the Project Locally

To test the project locally, follow these steps:

1. Build the project:
    ```sh
    dotnet build
    ```

2. Run the project:
    ```sh
    dotnet run
    ```

3. Open your browser and navigate to `http://localhost:5000` to see the application running.

## Testing with CodeSpaces

To test the project using GitHub CodeSpaces:

1. Open the repository in GitHub.
2. Click on the `Code` button and select `Open with CodeSpaces`.
3. Wait for the CodeSpace to initialize.
4. Once the environment is ready, open the terminal and run:
    ```sh
    dotnet run
    ```
5. Open the forwarded port to see the application running.

## Collaborating on the Project

We welcome contributions to this project. To contribute, follow these steps:

1. Fork the repository.
2. Create a new branch:
    ```sh
    git checkout -b feature/your-feature-name
    ```
3. Make your changes and commit them:
    ```sh
    git commit -m "Add your message here"
    ```
4. Push to the branch:
    ```sh
    git push origin feature/your-feature-name
    ```
5. Open a pull request on GitHub.

Please make sure to follow the [code of conduct](CODE_OF_CONDUCT.md) and [contributing guidelines](CONTRIBUTING.md).

## Home.razor Component

The `Home.razor` component is a Blazor page that provides a chat interface for users to interact with an AI model. It initializes a chat service based on the configuration settings and handles user input to generate responses from the AI model.

### Key Functionalities

- Displaying chat messages from the user and the AI assistant.
- Handling user input and sending it to the AI model for processing.
- Displaying loading indicators and error messages.
- Initializing the chat service based on the configuration settings.

### State Diagram

```mermaid
stateDiagram
    [*] --> Initializing
    Initializing --> Ready : OnInitialized
    Ready --> Loading : AskQuestion
    Loading --> Ready : ResponseReceived
    Ready --> Error : ErrorOccurred
    Error --> Ready : Retry