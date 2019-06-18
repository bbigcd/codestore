# var = 1
# while var == 1:
#     num = int(input("输入一个数字 ："))
#     print("你输入的数字是: ", num)
# print("Good bye!")

# class MyNumbers:
#     def __iter__(self):
#         self.a = 1
#         return self
    
#     def __next__(self):
#         x = self.a
#         self.a += 1
#         return x

# myClass = MyNumbers()
# myiter = iter(myClass)

# print(next(myiter))
# print(next(myiter))
# print(next(myiter))
# print(next(myiter))
# print(next(myiter))

# import sys

# def fibonacci(n):
#     a, b, counter = 0, 1, 0
#     while True:
#         if(counter > n):
#             return
#         yield a
#         a, b = b, a + b
#         counter += 1
# f = fibonacci(10)

# while True:
#     try:
#         print(next(f), end=" ")
#     except StopIteration:
#         sys.exit()

num = 1
def fun1():
    global num
    print(num)
    num = 123
    print(num)
fun1()
print(num)

def outer():
    num = 10
    def inner():
        nonlocal num   # nonlocal关键字声明
        num = 100
        print(num)
    inner()
    print(num)
outer()

import study2

study2.print_func("bbigcd")