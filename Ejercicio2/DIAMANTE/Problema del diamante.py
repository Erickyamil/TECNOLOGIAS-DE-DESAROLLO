class A:
    def method(self):
        print("from A")

class B(A):
    def method(self):
        print("from B")
        super().method()

class C(A):
    def method(self):
        print("from C")
        super().method()

class D(B, C):
    def method(self):
        print("from D")
        super().method()

d = D()
d.method()

print(D.mro())
