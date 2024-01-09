```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **751.2 ns** |   **397.5 ns** |  **21.79 ns** |   **727.5 ns** |   **770.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.9 ns |   578.0 ns |  31.68 ns |   679.6 ns |   738.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   698.2 ns |   577.5 ns |  31.65 ns |   675.1 ns |   734.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   732.6 ns |   530.7 ns |  29.09 ns |   701.8 ns |   759.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.9 ns |   240.0 ns |  13.15 ns |   692.8 ns |   718.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,645.4 ns** | **2,895.3 ns** | **158.70 ns** | **7,475.2 ns** | **7,789.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,268.0 ns | 1,769.4 ns |  96.99 ns | 7,181.3 ns | 7,372.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,207.4 ns | 3,513.3 ns | 192.57 ns | 6,991.2 ns | 7,360.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,449.0 ns |   444.6 ns |  24.37 ns | 7,424.5 ns | 7,473.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,279.5 ns | 2,015.7 ns | 110.49 ns | 7,214.1 ns | 7,407.1 ns | 0.1221 | 0.1144 |  10.23 KB |
