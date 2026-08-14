def sumar(num1, num2):
    total = num1 + num2
    return total


def resta(num1, num2):
    total = num1 - num2
    return total


def dividir(n, y):
    return n / y


def multiplicar(num1, num2):
    total = num1 * num2
    return total


def main():
    num1 = 12
    num2 = 45

    print(sumar(num1, num2))
    print(resta(num1, num2))
    print(dividir(num1, num2))
    print(multiplicar(num1, num2))


if __name__ == "__main__":
    main()
