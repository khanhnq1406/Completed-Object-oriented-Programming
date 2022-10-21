from math import pi
from typing import Type
class Pizza:
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
    def price (self): return 5.00 + 0.05 * self.area
    @property
    def area (self): return pi * self.radius ** 2
    @property
    def radius (self): return self. diameter / 2
    
    def __str__(self):
        return f'{self.diameter}" round pizza'

pizza = Pizza(16)
print (f"A {pizza} will cost ${pizza.price:.2f}")