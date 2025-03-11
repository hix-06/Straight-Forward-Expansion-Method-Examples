# Straight Forward Expansion Method - Detailed Solutions

## Example 1: Oscillator with Quadratic Nonlinearity and Forcing
Consider the differential equation: 
$$\ddot{x} + \omega_0^2 x + \varepsilon x^2 = F_0 \sin(\Omega t)$$

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + \varepsilon^2 \ddot{x}_2 + ... + \omega_0^2(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...) + \varepsilon(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^2 = F_0 \sin(\Omega t)$$

### Step 3: Expand the quadratic term
$$(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^2 = x_0^2 + 2x_0(\varepsilon x_1) + (\varepsilon x_1)^2 + ... = x_0^2 + 2\varepsilon x_0 x_1 + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0 \sin(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0^2) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero
Order ε^0 equation: 
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0 \sin(\Omega t)$$

Order ε^1 equation: 
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^2$$

### Step 6: Solve the order ε^0 equation
This is a standard forced harmonic oscillator. The general solution is:

$$x_0(t) = A\cos(\omega_0 t) + B\sin(\omega_0 t) + \frac{F_0\sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

For simplicity, let's assume initial conditions $x(0) = 0$ and $\dot{x}(0) = 0$.

Applying these conditions: 
$$x_0(0) = A + 0 = 0 \implies A = 0$$

$$\dot{x}_0(0) = \omega_0 B + \frac{\Omega F_0}{\omega_0^2 - \Omega^2} = 0 \implies B = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}$$

Therefore: 
$$x_0(t) = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}\sin(\omega_0 t) + \frac{F_0}{\omega_0^2 - \Omega^2}\sin(\Omega t)$$

Let's denote $\frac{F_0}{\omega_0^2 - \Omega^2} = D$ for brevity: 
$$x_0(t) = -\frac{\Omega D}{\omega_0}\sin(\omega_0 t) + D\sin(\Omega t)$$

### Step 7: Solve the order ε^1 equation
Now we substitute $x_0(t)$ into the equation for $x_1(t)$:

$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^2 = -\left(-\frac{\Omega D}{\omega_0}\sin(\omega_0 t) + D\sin(\Omega t)\right)^2$$

Expanding this quadratic term: 
$$x_0^2 = \frac{\Omega^2 D^2}{\omega_0^2}\sin^2(\omega_0 t) - \frac{2\Omega D^2}{\omega_0}\sin(\omega_0 t)\sin(\Omega t) + D^2\sin^2(\Omega t)$$

Using the trigonometric identities: 
$$\sin^2(\theta) = \frac{1-\cos(2\theta)}{2}$$
$$\sin(\theta_1)\sin(\theta_2) = \frac{\cos(\theta_1-\theta_2)-\cos(\theta_1+\theta_2)}{2}$$

We get: 
$$x_0^2 = \frac{\Omega^2 D^2}{2\omega_0^2}[1-\cos(2\omega_0 t)] - \frac{\Omega D^2}{\omega_0}[\cos(\omega_0 t-\Omega t)-\cos(\omega_0 t+\Omega t)] + \frac{D^2}{2}[1-\cos(2\Omega t)]$$

Rearranging: 
$$x_0^2 = \frac{\Omega^2 D^2}{2\omega_0^2} + \frac{D^2}{2} - \frac{\Omega^2 D^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t-\Omega t) + \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t+\Omega t) - \frac{D^2}{2}\cos(2\Omega t)$$

Now the equation for $x_1(t)$ becomes: 
$$\ddot{x}_1 + \omega_0^2 x_1 = -\frac{\Omega^2 D^2}{2\omega_0^2} - \frac{D^2}{2} + \frac{\Omega^2 D^2}{2\omega_0^2}\cos(2\omega_0 t) + \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t-\Omega t) - \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t+\Omega t) + \frac{D^2}{2}\cos(2\Omega t)$$

The particular solution for $x_1(t)$ has the form: 
$$x_1(t) = \frac{1}{\omega_0^2}\left(-\frac{\Omega^2 D^2}{2\omega_0^2} - \frac{D^2}{2}\right) + \frac{\frac{\Omega^2 D^2}{2\omega_0^2}}{\omega_0^2 - 4\omega_0^2}\cos(2\omega_0 t) + \frac{\frac{\Omega D^2}{\omega_0}}{\omega_0^2 - (\omega_0-\Omega)^2}\cos(\omega_0 t-\Omega t) - \frac{\frac{\Omega D^2}{\omega_0}}{\omega_0^2 - (\omega_0+\Omega)^2}\cos(\omega_0 t+\Omega t) + \frac{\frac{D^2}{2}}{\omega_0^2 - 4\Omega^2}\cos(2\Omega t)$$

Simplifying: 
$$x_1(t) = -\frac{D^2}{2\omega_0^2}\left(\frac{\Omega^2}{\omega_0^2} + 1\right) - \frac{\Omega^2 D^2}{6\omega_0^4}\cos(2\omega_0 t) + \frac{\Omega D^2}{\omega_0(2\omega_0\Omega - \Omega^2)}\cos(\omega_0 t-\Omega t) - \frac{\Omega D^2}{\omega_0(2\omega_0\Omega + \Omega^2)}\cos(\omega_0 t+\Omega t) + \frac{D^2}{2(\omega_0^2 - 4\Omega^2)}\cos(2\Omega t)$$

Note: When $\omega_0 = 2\Omega$, we would have a resonance case that would require special handling.

### Step 8: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results: 
$$x(t) = -\frac{\Omega D}{\omega_0}\sin(\omega_0 t) + D\sin(\Omega t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Where $x_1(t)$ is the solution found in Step 7.

## Example 2: Oscillator with Mixed Nonlinear Terms (x·ẋ)
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
Order ε^0 equation: 
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0\cos(\Omega t)$$

Order ε^1 equation: 
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0\dot{x}_0$$

### Step 6: Solve the order ε⁰ equation using only the particular solution
For the forced harmonic oscillator, we'll use just the particular solution:

$$x_0(t) = \frac{F_0\cos(\Omega t)}{\omega_0^2 - \Omega^2}$$

Let $D = \frac{F_0}{\omega_0^2 - \Omega^2}$ for brevity: $x_0(t) = D\cdot\cos(\Omega t)$

### Step 7: Compute ẋ₀(t)
$$\dot{x}_0(t) = -D\cdot\Omega\cdot\sin(\Omega t)$$

### Step 8: Calculate x₀(t)·ẋ₀(t) for the order ε¹ equation
$$x_0(t)\cdot\dot{x}_0(t) = D\cdot\cos(\Omega t)\cdot(-D\cdot\Omega\cdot\sin(\Omega t)) = -D^2\cdot\Omega\cdot\cos(\Omega t)\cdot\sin(\Omega t)$$

Using the trigonometric identity: $\cos(a)\cdot\sin(a) = \frac{\sin(2a)}{2}$

$$x_0(t)\cdot\dot{x}_0(t) = -D^2\cdot\Omega\cdot\frac{\sin(2\Omega t)}{2} = -\frac{D^2\cdot\Omega\cdot\sin(2\Omega t)}{2}$$

### Step 9: Solve the order ε¹ equation
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0\dot{x}_0 = \frac{D^2\cdot\Omega\cdot\sin(2\Omega t)}{2}$$

For a forcing term of the form $\sin(2\Omega t)$, the particular solution has the form: $x_{1p}(t) = C\cdot\sin(2\Omega t)$

Substituting into the differential equation: 
$$-4\Omega^2 C\cdot\sin(2\Omega t) + \omega_0^2 C\cdot\sin(2\Omega t) = \frac{D^2\cdot\Omega\cdot\sin(2\Omega t)}{2}$$

Equating coefficients: 
$$C(\omega_0^2 - 4\Omega^2) = \frac{D^2\cdot\Omega}{2}$$

Therefore: 
$$C = \frac{D^2\cdot\Omega}{2(\omega_0^2 - 4\Omega^2)}$$

And: 
$$x_{1p}(t) = \frac{D^2\cdot\Omega\cdot\sin(2\Omega t)}{2(\omega_0^2 - 4\Omega^2)}$$

Substituting $D = \frac{F_0}{\omega_0^2 - \Omega^2}$: 
$$x_{1p}(t) = \frac{F_0^2\cdot\Omega\cdot\sin(2\Omega t)}{2(\omega_0^2 - \Omega^2)^2(\omega_0^2 - 4\Omega^2)}$$

### Step 10: Final approximate solution
$$x(t) \approx x_0(t) + \varepsilon x_1(t) = \frac{F_0\cdot\cos(\Omega t)}{\omega_0^2 - \Omega^2} + \varepsilon\cdot\frac{F_0^2\cdot\Omega\cdot\sin(2\Omega t)}{2(\omega_0^2 - \Omega^2)^2(\omega_0^2 - 4\Omega^2)}$$

This gives us a simplified approximate solution to order ε, valid for the steady-state response when:

- Ω ≠ ω₀ (to avoid primary resonance)
- Ω ≠ ω₀/2 (to avoid secondary resonance)

The solution shows that the nonlinear term generates a frequency component at 2Ω (twice the forcing frequency), which is a characteristic feature of nonlinear systems.
