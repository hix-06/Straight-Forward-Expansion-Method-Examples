# Additional Examples Using Straight Forward Expansion Method

## Example 3: Oscillator with Mixed Nonlinear Terms (x·ẋ)

Consider the equation:
$$\ddot{x} + \omega_0^2 x + \varepsilon x\dot{x} = F_0\cos(\Omega t)$$

This includes a mixed nonlinear term (x·ẋ) which is common in systems with nonlinear damping.

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + ... + \omega_0^2(x_0 + \varepsilon x_1 + ...) + \varepsilon(x_0 + \varepsilon x_1 + ...)(\dot{x}_0 + \varepsilon \dot{x}_1 + ...) = F_0\cos(\Omega t)$$

### Step 3: Expand the nonlinear term
$$x\dot{x} = (x_0 + \varepsilon x_1 + ...)(\dot{x}_0 + \varepsilon \dot{x}_1 + ...) = x_0\dot{x}_0 + \varepsilon(x_0\dot{x}_1 + x_1\dot{x}_0) + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0\cos(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0\dot{x}_0) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0\cos(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0\dot{x}_0$$

## Step 6: Solve the order ε⁰ equation using only the particular solution
For the forced harmonic oscillator, we'll use just the particular solution:

x₀(t) = F₀cos(Ωt)/(ω₀² - Ω²)

Let D = F₀/(ω₀² - Ω²) for brevity: 
x₀(t) = D·cos(Ωt)

## Step 7: Compute ẋ₀(t)
ẋ₀(t) = -D·Ω·sin(Ωt)

## Step 8: Calculate x₀(t)·ẋ₀(t) for the order ε¹ equation
x₀(t)·ẋ₀(t) = D·cos(Ωt)·(-D·Ω·sin(Ωt)) = -D²·Ω·cos(Ωt)·sin(Ωt)

Using the trigonometric identity: cos(a)·sin(a) = sin(2a)/2

x₀(t)·ẋ₀(t) = -D²·Ω·sin(2Ωt)/2

## Step 9: Solve the order ε¹ equation
ẍ₁ + ω₀²x₁ = -x₀ẋ₀ = D²·Ω·sin(2Ωt)/2

For a forcing term of the form sin(2Ωt), the particular solution has the form:
x₁ₚ(t) = C·sin(2Ωt)

Substituting into the differential equation:
-4Ω²C·sin(2Ωt) + ω₀²C·sin(2Ωt) = D²·Ω·sin(2Ωt)/2

Equating coefficients:
C(ω₀² - 4Ω²) = D²·Ω/2

Therefore:
C = D²·Ω / (2(ω₀² - 4Ω²))

And:
x₁ₚ(t) = D²·Ω·sin(2Ωt) / (2(ω₀² - 4Ω²))

Substituting D = F₀/(ω₀² - Ω²):
x₁ₚ(t) = F₀²·Ω·sin(2Ωt) / (2(ω₀² - Ω²)²(ω₀² - 4Ω²))

## Step 10: Final approximate solution
x(t) ≈ x₀(t) + εx₁(t)
    = F₀·cos(Ωt)/(ω₀² - Ω²) + ε·F₀²·Ω·sin(2Ωt)/(2(ω₀² - Ω²)²(ω₀² - 4Ω²))

This gives us a simplified approximate solution to order ε, valid for the steady-state response when:
1. Ω ≠ ω₀ (to avoid primary resonance)
2. Ω ≠ ω₀/2 (to avoid secondary resonance)

The solution shows that the nonlinear term generates a frequency component at 2Ω (twice the forcing frequency), which is a characteristic feature of nonlinear systems.


## Example 4: Oscillator with Rational Nonlinearity

Consider the equation:
$$\ddot{x} + \omega_0^2 x + \varepsilon\frac{1}{1+x^2} = F_0\sin(\Omega t)$$

This includes a rational nonlinearity which appears in certain mechanical and electrical systems.

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + ... + \omega_0^2(x_0 + \varepsilon x_1 + ...) + \varepsilon\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = F_0\sin(\Omega t)$$

### Step 3: Expand the rational nonlinear term
For the term $\frac{1}{1+x^2}$, we use the binomial series expansion:
$$\frac{1}{1+x^2} = 1 - x^2 + x^4 - x^6 + ... \text{ for } |x^2| < 1$$

Substituting our series expansion:
$$\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = 1 - (x_0 + \varepsilon x_1 + ...)^2 + O(x^4)$$

Further expanding:
$$\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = 1 - x_0^2 - 2\varepsilon x_0 x_1 + O(\varepsilon^2) + O(x^4)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0\sin(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + 1 - x_0^2) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0\sin(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + x_0^2$$

### Step 6: Solve the order ε^0 equation

This is a standard forced harmonic oscillator with solution:
$$x_0(t) = A\cos(\omega_0 t) + B\sin(\omega_0 t) + \frac{F_0\sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

Using initial conditions $x(0) = 0$ and $\dot{x}(0) = 0$:

From $x_0(0) = 0$:
$$A + 0 = 0 \implies A = 0$$

From $\dot{x}_0(0) = 0$:
$$\omega_0 B + \frac{\Omega F_0\cos(0)}{\omega_0^2 - \Omega^2} = 0 \implies B = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}$$

Therefore:
$$x_0(t) = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}\sin(\omega_0 t) + \frac{F_0\sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

Let $G = \frac{F_0}{\omega_0^2 - \Omega^2}$ for brevity:
$$x_0(t) = -\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t)$$

### Step 7: Calculate $x_0^2(t)$ for the order ε^1 equation
$$x_0^2(t) = \left[-\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t)\right]^2$$

Expanding:
$$x_0^2(t) = \frac{\Omega^2 G^2}{\omega_0^2}\sin^2(\omega_0 t) - 2\frac{\Omega G^2}{\omega_0}\sin(\omega_0 t)\sin(\Omega t) + G^2\sin^2(\Omega t)$$

Using trigonometric identities:
$$\sin^2(a) = \frac{1-\cos(2a)}{2}$$
$$\sin(a)\sin(b) = \frac{\cos(a-b)-\cos(a+b)}{2}$$

We get:
$$x_0^2(t) = \frac{\Omega^2 G^2}{2\omega_0^2}[1-\cos(2\omega_0 t)] - \frac{\Omega G^2}{\omega_0}[\cos(\omega_0-\Omega)t - \cos(\omega_0+\Omega)t] + \frac{G^2}{2}[1-\cos(2\Omega t)]$$

Rearranging:
$$x_0^2(t) = \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right) - \frac{\Omega^2 G^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0}\cos(\omega_0+\Omega)t - \frac{G^2}{2}\cos(2\Omega t)$$

### Step 8: Solve the order ε^1 equation
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + x_0^2$$

Substituting our expression for $x_0^2(t)$:
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right) - \frac{\Omega^2 G^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0}\cos(\omega_0+\Omega)t - \frac{G^2}{2}\cos(2\Omega t)$$

Let $K = -1 + \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right)$ for the constant term.

The particular solution for $x_1(t)$ has the form:
$$x_1(t) = \frac{K}{\omega_0^2} + \frac{-\frac{\Omega^2 G^2}{2\omega_0^2}}{\omega_0^2-(2\omega_0)^2}\cos(2\omega_0 t) + \frac{-\frac{\Omega G^2}{\omega_0}}{\omega_0^2-(\omega_0-\Omega)^2}\cos(\omega_0-\Omega)t + \frac{\frac{\Omega G^2}{\omega_0}}{\omega_0^2-(\omega_0+\Omega)^2}\cos(\omega_0+\Omega)t + \frac{-\frac{G^2}{2}}{\omega_0^2-(2\Omega)^2}\cos(2\Omega t)$$

Simplifying:
$$x_1(t) = \frac{K}{\omega_0^2} + \frac{\Omega^2 G^2}{6\omega_0^4}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0[\omega_0^2-(\omega_0-\Omega)^2]}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0[\omega_0^2-(\omega_0+\Omega)^2]}\cos(\omega_0+\Omega)t - \frac{G^2}{2[\omega_0^2-(2\Omega)^2]}\cos(2\Omega t)$$

This is the particular solution. We also need to add the homogeneous solution $C\cos(\omega_0 t) + E\sin(\omega_0 t)$ with constants $C$ and $E$ determined by the initial conditions that $x_1(0) = 0$ and $\dot{x}_1(0) = 0$.

### Step 9: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = -\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

This gives us the approximate solution to order $\varepsilon$ for the oscillator with rational nonlinearity.
