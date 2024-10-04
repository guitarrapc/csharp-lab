```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,237.6 ns** |    **148.28 ns** |     **8.13 ns** |     **1,230.7 ns** |     **1,246.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,363.9 ns |    178.79 ns |     9.80 ns |     1,353.3 ns |     1,372.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,593.5 ns |     67.00 ns |     3.67 ns |     1,589.5 ns |     1,596.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,597.6 ns |    416.85 ns |    22.85 ns |     2,582.4 ns |     2,623.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.9 ns |     21.64 ns |     1.19 ns |       199.5 ns |       201.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.4 ns |     10.09 ns |     0.55 ns |       284.9 ns |       286.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       487.9 ns |     91.48 ns |     5.01 ns |       483.6 ns |       493.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,808.5 ns** |  **8,757.88 ns** |   **480.05 ns** | **1,553,502.6 ns** | **1,554,361.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,777.4 ns |  2,670.71 ns |   146.39 ns |   617,612.9 ns |   617,893.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,997.7 ns | 13,308.55 ns |   729.49 ns |   659,156.0 ns |   660,447.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,993.1 ns | 46,000.42 ns | 2,521.44 ns | 1,380,401.0 ns | 1,384,900.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,524.0 ns |  9,370.74 ns |   513.64 ns |   163,025.0 ns |   164,051.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,869.1 ns |    743.64 ns |    40.76 ns |    91,834.4 ns |    91,914.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,860.8 ns |  3,420.71 ns |   187.50 ns |    65,674.2 ns |    66,049.2 ns |      - |      40 B |
