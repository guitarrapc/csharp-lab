```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **68.4923 ns** |  **11.1738 ns** |  **0.6125 ns** |  **67.8062 ns** |  **68.9838 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0354 ns |   0.1407 ns |  0.0077 ns |   0.0308 ns |   0.0443 ns |         - |
| TryParseCidrString | 1      |  72.8646 ns |   1.5864 ns |  0.0870 ns |  72.7654 ns |  72.9275 ns |         - |
| TryParseCidrBytes  | 1      |   2.7593 ns |   0.3434 ns |  0.0188 ns |   2.7423 ns |   2.7795 ns |         - |
| **NewFromCidrString**  | **3**      | **199.4876 ns** |  **11.2677 ns** |  **0.6176 ns** | **199.0105 ns** | **200.1852 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6540 ns |   0.2574 ns |  0.0141 ns |   0.6380 ns |   0.6647 ns |         - |
| TryParseCidrString | 3      | 228.0537 ns | 273.4133 ns | 14.9867 ns | 210.9176 ns | 238.7115 ns |         - |
| TryParseCidrBytes  | 3      |   9.3485 ns |   0.7689 ns |  0.0421 ns |   9.3020 ns |   9.3842 ns |         - |
