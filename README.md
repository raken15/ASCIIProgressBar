# ASCII Progress Bar

A simple and interactive **ASCII Progress Bar** in C#. The progress bar gradually fills up by revealing a user-provided string character by character.

## Features
- Dynamic progress bar that fills with a **custom string**.
- Smooth character-by-character animation.
- Displays **percentage completion**.
- Uses **carriage return (`\r`)** to overwrite the line for a clean console output.

## Demo
```plaintext
Enter a string to display in the progress bar: LOADING

Loading...
[L------] 14%
[LO-----] 28%
[LOA----] 42%
[LOAD---] 57%
[LOADI--] 71%
[LOADIN-] 85%
[LOADING] 100%

Done!
```

## Installation & Setup
1. **Clone the repository**
   ```sh
   git clone https://github.com/raken15/ASCIIProgressBar.git
   cd ASCIIProgressBar
   ```

2. **Run the program**
   ```sh
   cd ASCIIProgressBarApp
   dotnet run
   ```

## Contributing
Feel free to submit issues or pull requests to improve this project.

## License
This project is licensed under the **MIT License**.
