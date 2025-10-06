# Display the welcome message as required
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt the user to enter the package weight
weight = float(input("Please enter the package weight: "))

# Check if the weight is greater than 50
if weight > 50:
    # If weight is too heavy, display error and exit
    print("Package too heavy to be shipped via Package Express. Have a good day.")
else:
    # Prompt the user for package width
    width = float(input("Please enter the package width: "))
    
    # Prompt the user for package height
    height = float(input("Please enter the package height: "))
    
    # Prompt the user for package length
    length = float(input("Please enter the package length: "))
    
    # Calculate the total dimensions
    dimension_total = width + height + length
    
    # Check if the total dimensions exceed the limit
    if dimension_total > 50:
        # If dimensions are too large, display error and exit
        print("Package too big to be shipped via Package Express.")
    else:
        # Calculate the volume (width * height * length)
        volume = width * height * length
        
        # Calculate the shipping quote based on volume and weight
        quote = (volume * weight) / 100
        
        # Display the final quote formatted to 2 decimal places
        print(f"Your estimated total for shipping this package is: ${quote:.2f}")
        print("Thank you!")

