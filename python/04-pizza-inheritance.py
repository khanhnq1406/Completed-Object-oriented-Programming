from math import pi
from select import select
from time import sleep
from typing import Type
class Pizza:
    @property
    def price (self): return 5.00 + 0.05 * self.area + 0.50 * len(self.toppings)

    def add_topping(self, topping):
        if isinstance(topping,str):
            self.toppings.append(topping)
        elif isinstance(topping, (list, tuple)):
            self.toppings.extend(topping)
    
    @property 
    def toppings(self):
        if not hasattr(self, "_toppings"):
            self._toppings = []
        return self._toppings    

    def __str__(self):
        return f'{self.toppings if self.toppings else "no toppings"}'
class RoundPizza(Pizza):
    def __init__(self, diameter):
        self.diameter = diameter
    @property
    def diameter(self): return self._diameter

    @diameter.setter
    def diameter(self, diameter):
        if not isinstance(diameter, (int, float)):
            raise TypeError("The diameter must be an integer or float")
        elif diameter < 0:
            raise ValueError("The diameter must not be negative")
        else:
            self._diameter = diameter
    @property
    def area (self): return pi * self.radius ** 2
    @property
    def radius (self): return self. diameter / 2

    def __str__(self):
        return f'{self.diameter}" round pizza with {super().__str__()}'
class SquaredPizza(Pizza):
    def __init__(self, length):
        self.length = length
    @property
    def length(self): return self._length

    @length.setter
    def length(self, length):
        if not isinstance(length, (int, float)):
            raise TypeError("The length must be an integer or float")
        elif length < 0:
            raise ValueError("The length must not be negative")
        else:
            self._length = length
    @property
    def area (self): return self.length**2

    def __str__(self):
        return f'{self.length}" square pizza with {super().__str__()}'
pizza = RoundPizza(16)
print (f"A {pizza} will cost ${pizza.price:.2f}")
pizza.add_topping("Extra Cheese")
print (f"A {pizza} will cost ${pizza.price:.2f}")
pizza.add_topping(["Tomato", "Olives"])
print (f"A {pizza} will cost ${pizza.price:.2f}")

pizza = SquaredPizza(16)
print (f"A {pizza} will cost ${pizza.price:.2f}")
pizza.add_topping("Extra Cheese")
print (f"A {pizza} will cost ${pizza.price:.2f}")
pizza.add_topping(["Tomato", "Olives"])
print (f"A {pizza} will cost ${pizza.price:.2f}")