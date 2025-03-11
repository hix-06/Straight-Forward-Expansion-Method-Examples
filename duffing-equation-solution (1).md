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

### Step 7: Solve the order ε^1 equation (Very Simple Approach)

Now we need to solve:
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^3$$

Substituting our expression for $x_0(t)$:
$$\ddot{x}_1 + \omega_0^2 x_1 = -C^3[\cos(\Omega t) - \cos(\omega_0 t)]^3$$

We can break this down into a few key points:

1. When we expand $[\cos(\Omega t) - \cos(\omega_0 t)]^3$, we get terms with various frequencies
2. The forcing function on the right-hand side will contain terms with frequencies $\omega_0$, $3\omega_0$, $\Omega$, $3\Omega$, and mixed terms like $(2\omega_0 \pm \Omega)$ and $(2\Omega \pm \omega_0)$

3. The solution $x_1(t)$ will have the form:

$$x_1(t) = \sum \frac{\text{(coefficient)}\cos(\text{frequency} \cdot t)}{\omega_0^2 - (\text{frequency})^2}$$

For most terms, this gives a bounded oscillatory solution. However, for the term with frequency $\omega_0$, we have a denominator of $(\omega_0^2 - \omega_0^2) = 0$, which creates a resonance.

4. For this resonant term, the solution includes a secular term:

$$x_1(t) = ... + (some~constant) \cdot t \cdot \sin(\omega_0 t) + ...$$

This term grows linearly with time, indicating a limitation of this perturbation method.

### Step 8: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = C[\cos(\Omega t) - \cos(\omega_0 t)] + \varepsilon \left[\text{bounded oscillatory terms} + (some~constant) \cdot t \cdot \sin(\omega_0 t)\right] + O(\varepsilon^2)$$

This approximation is valid for small values of $\varepsilon$ and relatively short time intervals due to the secular term.
