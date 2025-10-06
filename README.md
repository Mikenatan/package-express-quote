# Package Express Shipping Quote App

This is a console-based Python application that calculates shipping quotes based on package weight and dimensions.

## How it works
- If weight > 50: Reject the package
- If total dimensions > 50: Reject the package
- Else: calculate quote using (width * height * length * weight) / 100

## Usage
Run the script with:
```
python3 package_quote.py
```

