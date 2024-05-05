import unittest

def mcd(a, b):
    # Si uno de los números es cero, el MCD es el otro número
    if a == 0:
        return b
    if b == 0:
        return a

    for k in range(min(a, b), 0, -1):
        if a % k == 0 and b % k == 0:
            return k


def mcd_cuatro_numeros(a, b, c, d):
    mcd_ab = mcd(a, b)
    mcd_cd = mcd(c, d)
    return mcd(mcd_ab, mcd_cd)

class TestOperaciones(unittest.TestCase):
    def test_mcd(self):
        # Pruebas para mcd_cuatro_numeros con diferentes casos
        esperado = 12
        actual = mcd_cuatro_numeros(24, 36, 48, 60)
        self.assertEqual(actual, esperado)

        esperado2 = 5
        actual2 = mcd_cuatro_numeros(10, 5, 20, 25)
        self.assertEqual(actual2, esperado2)

        esperado3 = 1
        actual3 = mcd_cuatro_numeros(7, 5, 12, 8)
        self.assertEqual(actual3, esperado3)

        esperado4 = 25
        actual4 = mcd_cuatro_numeros(100, 75, 150, 200)
        self.assertEqual(actual4, esperado4)

        esperado5 = 10
        actual5 = mcd_cuatro_numeros(50, 20, 40, 60)
        self.assertEqual(actual5, esperado5)


if __name__ == '__main__':
    unittest.main()
