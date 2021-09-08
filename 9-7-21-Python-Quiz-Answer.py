def doesBrickFit(a, b, c, w, h):
    return (a <= h and b <= w)
    
print(doesBrickFit(1, 1, 1, 1, 1))
print(doesBrickFit(1, 2, 1, 1, 1))
print(doesBrickFit(1, 2, 2, 1, 1))