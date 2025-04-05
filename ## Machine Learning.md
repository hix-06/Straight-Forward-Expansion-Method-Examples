## **Machine Learning**
**Dr. Eman Ibrahim**

---

### **1. Artificial Intelligence and Machine Learning**

- **Artificial Intelligence (AI)** is the broader field of creating machines that can think and act intelligently.
- **Machine Learning (ML)** is a **subset of AI** that focuses on teaching machines how to learn from data.
- Subfields of AI include:
  - **Machine Learning**
  - **Deep Learning**
  - **Neural Networks**
  - **Artificial Neural Networks (ANNs)**

---

### **2. Need for Machine Learning**

Machine learning is used across various industries to improve performance and automation. Key applications include:

- **Predictive Modeling**  
  Helps businesses make data-driven decisions by forecasting outcomes.

- **Natural Language Processing (NLP)**  
  Enables understanding and interpretation of human language (used in voice assistants, chatbots, translation).

- **Computer Vision**  
  Allows machines to interpret and analyze visual data (used in self-driving cars, surveillance, medical imaging).

- **Fraud Detection**  
  Detects suspicious or fraudulent behavior in finance, e-commerce, and advertising.

- **Recommendation Systems**  
  Suggests personalized content/products based on user behavior (e.g., Netflix, Amazon).

---

### **3. Types of Machine Learning Methods**

#### A. **Supervised Learning**
- Learns from labeled data (data with correct answers).
- **Techniques**: Regression, Classification.

#### B. **Unsupervised Learning**
- Learns patterns from **unlabeled data** (no feedback).
- **Techniques**: Clustering, Dimensionality Reduction.

#### C. **Reinforcement Learning**
- Learns by interacting with the environment.
- The algorithm receives feedback (reward or penalty) but is **not told how to correct mistakes**.

---

### **4. Core ML Techniques Explained**

- **Regression**
  - Predicts **numerical** outcomes.
  - Output is a continuous value (e.g., stock price = "$35/share").

- **Classification**
  - Predicts **categorical** outcomes.
  - Output belongs to a predefined class (e.g., Grade = "A", "B", etc.).

- **Clustering**
  - Groups similar data points together.
  - Common in **unsupervised learning**.

---

### **5. How Machine Learning Algorithms Work**

1. **Data Collection**
   - Gather relevant data (images, texts, numerical features, etc.).

2. **Data Preprocessing**
   - Clean the data (handle missing values, remove outliers).
   - Normalize or scale features.
   - Split data into **training** and **testing** sets.

3. **Choosing a Model**
   - Select a suitable model based on the task:
     - Classification, Regression, Clustering, etc.

4. **Training the Model**
   - Use training data to teach the model to recognize patterns and relationships.

5. **Evaluating the Model**
   - Test the model on unseen data.
   - Use metrics like:
     - Accuracy
     - Precision
     - Recall
     - Mean Squared Error

---

# Confusion Matrix Explained

## **Example: Doctor Diagnoses Pregnancy**
|                       | **Predicted: Pregnant** | **Predicted: Not Pregnant** |
|-----------------------|-------------------------|------------------------------|
| **Actually Pregnant** | True Positive (TP)      | False Negative (FN)          |
| **Actually Not Pregnant** | False Positive (FP)     | True Negative (TN)           |

- **TP (True Positive)**: The doctor correctly says a woman is pregnant, and she actually is.
- **FN (False Negative)**: The doctor says a woman is **not pregnant**, but she **is**.
- **FP (False Positive)**: The doctor says a woman **is pregnant**, but she is **not**.
- **TN (True Negative)**: The doctor correctly says a woman is **not pregnant**, and she isn't.

---

## **Evaluation Metrics**

### 1. **Accuracy**
$$
\text{Accuracy} = \frac{TP + TN}{TP + TN + FP + FN}
$$
- How often the prediction is correct.

---

### 2. **Precision (P)**
$$
P = \frac{TP}{TP + FP}
$$
- Of all women predicted to be pregnant, how many actually are.

---

### 3. **Recall (R) / Sensitivity / True Positive Rate**
$$
R = \frac{TP}{TP + FN}
$$
- Of all actually pregnant women, how many were correctly identified.

---

### 4. **F1 Score**
$$
F1 = \frac{2 \cdot P \cdot R}{P + R}
$$
- Harmonic mean of precision and recall. Useful for imbalanced data.

---

### 5. **True Positive Rate (TPR)**  
Same as **Recall**:
$$
TPR = \frac{TP}{TP + FN}
$$

---

### 6. **False Positive Rate (FPR)**
$$
FPR = \frac{FP}{FP + TN}
$$
- Mistakenly predicting pregnancy among non-pregnant women.

---

### 7. **True Negative Rate (TNR) / Specificity**
$$
TNR = \frac{TN}{FP + TN}
$$
- Correctly identifying non-pregnant women.

---

### 8. **Prevalence**
$$
\text{Prevalence} = \frac{TP + FN}{TP + TN + FP + FN}
$$
- Proportion of actually pregnant women in the population.

---

### 9. **Root Mean Squared Error (RMSE)**  
For regression problems (not classification):
$$
RMSE = \sqrt{\frac{1}{n} \sum_{i=1}^{n}(y_i - \hat{y}_i)^2}
$$
Where:
- $y_i$: actual value  
- $\hat{y}_i$: predicted value  
- $n$: number of observations

## **What is Clustering?**

Clustering is the process of organizing objects into groups (called *clusters*) such that:
- Objects **within the same cluster** are **similar**.
- Objects **in different clusters** are **dissimilar**.

## **What is Clustering?**

Clustering is the process of organizing objects into groups (called *clusters*) such that:
- Objects **within the same cluster** are **similar**.
- Objects **in different clusters** are **dissimilar**.

---

## **Why is Clustering Important?**

- Clustering is a key technique in **unsupervised learning**.
- It helps find **hidden structures** or **patterns** in **unlabeled data** (i.e., data without predefined categories or outcomes).

---

## **Applications of Clustering**

- **Marketing**:  
  Identifying groups of customers with similar behaviors based on a large dataset containing their properties and past records.

- **Biology**:  
  Classifying plants and animals based on their physical features and characteristics.

---

## **Types of Clustering**

### 1. **Hierarchical Clustering**

- **Agglomerative (Bottom-Up)**:  
  - Start with each object as its own cluster.  
  - Gradually merge the clusters step by step into larger clusters.

- **Divisive (Top-Down)**:  
  - Start with all objects in one big cluster.  
  - Recursively split it into smaller clusters.

---

### 2. **Partitioning Clustering**

- Objects are grouped into a predefined number of clusters (e.g., *k* clusters).

#### Common Algorithms:

- **K-Means**:  
  - Each cluster is represented by the **mean** of its data points.

- **K-Medoids**:  
  - Each cluster is represented by one of the **actual data points** (a "medoid") that lies near the center.
