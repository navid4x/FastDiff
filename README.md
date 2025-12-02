
⚡ FastDiff<T>

A robust and highly efficient deep object comparison library for .NET 10 (C#) designed for audit logging and change tracking. It uses a hybrid approach of **Compiled Expression Trees** for simple types and **Runtime Reflection** for complex types to generate precise, minimal JSON diffs.

---

 🎯 What is FastDiff<T>?

`FastDiff<T>` is a generic class that compares two instances of the same object (`oldObj` and `newObj`) and produces a clean, minimal **JSON output** detailing only the properties that have changed.

Why not use standard JSON libraries for comparison?

Standard serialization libraries compare entire objects, resulting in massive diff files even for small changes. `SmartDiffer<T>` only includes the properties that are truly different, significantly reducing log file size and improving auditing performance.

---

✨ Key Features & Strengths

| Feature | Benefit | Technical Implementation |
| :--- | :--- | :--- |
| **Minimal Diff Output** | Only changed properties are included, dramatically reducing log size and processing overhead. | Eliminates unchanged properties and objects from the final JSON structure. |
| **High Performance (Primitives)** | Comparison of simple types (`int`, `string`, `bool`, etc.) is extremely fast. | Uses **Compiled Expression Trees** for high-speed equality checks at runtime. |
| **Robust Stability** | Safely handles complex data structures without crashing the application startup. | Avoids static constructor exceptions by moving complex type logic (nested classes and collections) to **Runtime Delegates**. |
| **Deep Nested Object Support** | Recursively tracks changes within complex/nested class structures. | Dynamically calls `SmartDiffer<NestedType>.GetDiffJson` at runtime. |
| **Precise Collection Diff** | Accurately reports changes in lists and arrays without outputting the entire collection. | Implements **Item-by-Item Deep Diff** logic for list-like collections, reporting changes by index (`"[0]": { ... }`) and marking items as `Added` or `Removed`. |
| **Dictionary Safety** | Securely handles dictionaries (`Dictionary<K, V>`) to prevent Reflection errors. | Dictionaries are compared using a **full JSON serialization hash check** for maximum stability. |

---

⚙️ How to Use

The library exposes a single static method for generating the diff.

Prerequisites

* .NET 10 (or any compatible modern .NET version, like .NET 6/7/8/9/10)
* C#

Example

```csharp
public class UserProfile
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public List<Address> Addresses { get; set; } // Complex Collection
    public Settings UserSettings { get; set; } // Nested Object
}

// ... Create oldProfile and newProfile objects with differences ...

// Usage:
string diffJson = SmartDiffer<UserProfile>.GetDiffJson(oldProfile, newProfile);
````

### Expected Output Format (Minimal JSON)

If only the `FirstName` is changed, and an item in the `Addresses` list is updated:

```json
{
  "FirstName": {
    "OldValue": "Alice",
    "NewValue": "Alicia"
  },
  "Addresses": {
    "[0]": {
      "Street": {
        "OldValue": "123 Main St",
        "NewValue": "456 Oak Ave"
      }
    }
  },
  "UserSettings": {
    "Theme": {
      "OldValue": "Dark",
      "NewValue": "Light"
    }
  }
}
```
