# Straight Forward Expansion Method - Detailed Solutions

## Example 1: Forced Oscillator with Cubic Nonlinearity

Consider the forced Duffing equation:

$$\ddot{x} + \omega_0^2 x + \varepsilon x^3 = F_0 \cos(\Omega t)$$

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + \varepsilon^2 \ddot{x}_2 + ... + \omega_0^2(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...) + \varepsilon(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^3 = F_0 \cos(\Omega t)$$

### Step 3: Expand the cubic term
$$(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^3 = x_0^3 + 3x_0^2(\varepsilon x_1) + 3x_0(\varepsilon x_1)^2 + (\varepsilon x_1)^3 + ... = x_0^3 + 3\varepsilon x_0^2 x_1 + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0 \cos(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0^3) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero
Order ε^0 equation:
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0 \cos(\Omega t)$$

Order ε^1 equation:
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^3$$

### Step 6: Solve the order ε^0 equation
This is a standard forced harmonic oscillator. The general solution consists of the homogeneous solution plus the particular solution:

$$x_0(t) = A\cos(\omega_0 t) + B\sin(\omega_0 t) + \frac{F_0\cos(\Omega t)}{\omega_0^2 - \Omega^2}$$

Where A and B are constants determined by initial conditions. For simplicity, let's assume the system starts from rest at the origin: $x(0) = 0$ and $\dot{x}(0) = 0$.

Applying these conditions:
$$x_0(0) = A + \frac{F_0}{\omega_0^2 - \Omega^2} = 0 \Rightarrow A = -\frac{F_0}{\omega_0^2 - \Omega^2}$$

$$\dot{x}_0(0) = -\omega_0 A \sin(\omega_0 \cdot 0) + \omega_0 B \cos(\omega_0 \cdot 0) - \frac{\Omega F_0 \sin(\Omega \cdot 0)}{\omega_0^2 - \Omega^2} = 0 \Rightarrow B = 0$$

Therefore:
$$x_0(t) = -\frac{F_0}{\omega_0^2 - \Omega^2}\cos(\omega_0 t) + \frac{F_0}{\omega_0^2 - \Omega^2}\cos(\Omega t) = \frac{F_0}{\omega_0^2 - \Omega^2}[\cos(\Omega t) - \cos(\omega_0 t)]$$

Let's denote $\frac{F_0}{\omega_0^2 - \Omega^2} = C$ for brevity:
$$x_0(t) = C[\cos(\Omega t) - \cos(\omega_0 t)]$$

### Step 7: Solve the order ε^1 equation (Simplified Approach)

Now we substitute $x_0(t)$ into the equation for $x_1(t)$:

$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^3 = -C^3[\cos(\Omega t) - \cos(\omega_0 t)]^3$$

To simplify this cubic expression, we can use the trigonometric identity for the cube:
$$\cos^3(θ) = \frac{3\cos(θ) + \cos(3θ)}{4}$$

And we'll use the fact that:
$$[\cos(\Omega t) - \cos(\omega_0 t)]^3 = \cos^3(\Omega t) - 3\cos^2(\Omega t)\cos(\omega_0 t) + 3\cos(\Omega t)\cos^2(\omega_0 t) - \cos^3(\omega_0 t)$$

This gives us terms with frequencies:
- $\omega_0$ and $3\omega_0$ (from expanding $\cos^3(\omega_0 t)$)
- $\Omega$ and $3\Omega$ (from expanding $\cos^3(\Omega t)$)
- $(2\omega_0 \pm \Omega)$ (from terms like $\cos(\Omega t)\cos^2(\omega_0 t)$)
- $(2\Omega \pm \omega_0)$ (from terms like $\cos^2(\Omega t)\cos(\omega_0 t)$)

The particular solution for $x_1(t)$ has the form:

$$x_1(t) = \sum_i \frac{K_i\cos(\alpha_i t)}{\omega_0^2 - \alpha_i^2}$$

Where $\alpha_i$ represents each of the frequencies in the forcing function, and $K_i$ are constants.

For the term with frequency $\omega_0$ (which would cause resonance since $\omega_0^2 - \omega_0^2 = 0$), the particular solution has the form:
$$\frac{K_{\omega_0}t\sin(\omega_0 t)}{2\omega_0}$$

This secular term grows unbounded with time, indicating a limitation of the perturbation method for this case.

### Step 8: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = C[\cos(\Omega t) - \cos(\omega_0 t)] + \varepsilon x_1(t) + O(\varepsilon^2)$$

Where $x_1(t)$ is the simplified solution found in Step 7 that contains both bounded oscillatory terms and a secular term proportional to $t\sin(\omega_0 t)$.
