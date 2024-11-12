# LayerBoost

[LayerBoost](https://github.com/npmStart0/LayerBoost) is a Command Line Interface (CLI) tool designed to simplify and automate common tasks in .NET projects that use a three-layer architecture. With LayerBoost, developers can set up projects, manage CRUD operations, create Mappers, and define custom `GetBy` functions quickly and easily.

## Features

- **Initialize an Empty Project Structure**: Sets up a basic .NET project layout with separate folders for the Data Access Layer (DAL), Business Logic Layer (BLL), and API layer.
- **CRUD Generation**: Quickly creates CRUD (Create, Read, Update, Delete) operations for specified table models within the DAL, with optional mappings to DTOs.
- **Mapper Creation**: Automatically generates Mapper classes between models in the DAL and DTO layers based on project data.
- **Custom GetBy Function Creation**: Easily defines custom `GetBy` functions to retrieve data based on specific fields.

## How It Works

Each time the CLI tool runs in a project directory, it checks for a `data.json` file:
- **If the file doesn’t exist**, it will automatically be created with placeholder values.
- **If the file exists**, LayerBoost will reference it for project configuration, including:
  - Sub-project names
  - Folder paths
  - Mappings between models in the DAL and DTO layers

This structure reduces redundant prompts, enhancing your development workflow.

## Installation

After uploading the base version, we will update the installation instructions.

### To run the development version:
```bash
git clone https://github.com/npmStart0/LayerBoost
dotnet run --project <path-to-project> -- <command> <options>
```

## Configuration File: `data.json`

The `data.json` file stores essential project information for LayerBoost, minimizing redundant prompts for user input.

### Example Structure of `data.json`

```json
{
  "SubProjects": ["MyApi", "MyBLL", "MyDAL"],
  "FolderNames": ["API", "BLL", "DAL"],
  "ModelMappings": {
    "UserDal": "UserDTO",
    "ProductDal": "ProductDTO"
  }
}
```

## Project Structure

Here’s an overview of LayerBoost's directory structure:

- **Commands**: Contains CLI commands, such as those for generating CRUD operations and creating Mappers.
- **Data**: Manages operations related to the `data.json` configuration file.
- **Utils**: Includes helper functions for tasks like JSON file handling and data validation.

## Requirements

- **.NET 6 or higher**
- **Write permissions**: LayerBoost requires write permissions in the project directory to create and manage the `data.json` file.

## Contributing

Contributions are welcome! Please feel free to submit issues, create pull requests, or suggest new features.
