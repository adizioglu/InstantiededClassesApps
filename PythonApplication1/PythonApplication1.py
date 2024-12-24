# Define a class
class Car:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def drive(self):
        print(f"{self.brand} {self.model} is driving.")

# Instantiate the class
my_car = Car("Toyota", "Corolla")

# Use the object
print(my_car.brand)  # Output: Toyota
my_car.drive()       # Output: Toyota Corolla is driving.

