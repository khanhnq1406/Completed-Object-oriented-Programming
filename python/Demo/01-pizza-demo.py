from math import pi
from typing import Type
class Pizza:
    def __init__(self, diameter):
        self.diameter = diameter

pizza = Pizza(16)
print (f"A {pizza} will cost ${pizza.price:.2f}")