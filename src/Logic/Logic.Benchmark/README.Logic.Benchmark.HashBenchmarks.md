```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,324.4 ns** |     **27.90 ns** |     **1.53 ns** |     **1,322.8 ns** |     **1,325.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,530.5 ns |     59.83 ns |     3.28 ns |     1,526.8 ns |     1,532.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,753.2 ns |     35.96 ns |     1.97 ns |     1,750.9 ns |     1,754.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,685.9 ns |    242.18 ns |    13.27 ns |     2,676.5 ns |     2,701.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       186.4 ns |      9.70 ns |     0.53 ns |       185.9 ns |       187.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       315.4 ns |    127.24 ns |     6.97 ns |       310.1 ns |       323.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       462.9 ns |     26.85 ns |     1.47 ns |       461.6 ns |       464.5 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,314.3 ns |     62.71 ns |     3.44 ns |     1,312.1 ns |     1,318.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,498.3 ns |      9.80 ns |     0.54 ns |     1,497.9 ns |     1,498.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,722.9 ns |     83.48 ns |     4.58 ns |     1,718.3 ns |     1,727.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,634.8 ns |    250.46 ns |    13.73 ns |     2,625.8 ns |     2,650.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       180.6 ns |      7.39 ns |     0.40 ns |       180.2 ns |       181.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       259.0 ns |     40.65 ns |     2.23 ns |       256.9 ns |       261.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       460.3 ns |     90.03 ns |     4.93 ns |       454.6 ns |       463.3 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,196.3 ns** |  **3,619.12 ns** |   **198.38 ns** | **1,553,968.0 ns** | **1,554,327.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   618,027.2 ns |  9,159.93 ns |   502.09 ns |   617,721.4 ns |   618,606.7 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,598.7 ns | 12,225.59 ns |   670.13 ns |   658,847.3 ns |   660,134.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,380,753.1 ns |  7,005.43 ns |   383.99 ns | 1,380,415.6 ns | 1,381,170.9 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,083.6 ns |  1,123.31 ns |    61.57 ns |   163,013.6 ns |   163,129.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,186.6 ns |  5,490.07 ns |   300.93 ns |    91,952.8 ns |    92,526.1 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,750.4 ns |  5,367.75 ns |   294.22 ns |    65,556.5 ns |    66,089.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,156.9 ns |  2,012.66 ns |   110.32 ns | 1,554,050.7 ns | 1,554,271.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,689.5 ns |  3,125.16 ns |   171.30 ns |   617,556.8 ns |   617,882.9 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,588.0 ns | 24,885.87 ns | 1,364.08 ns |   658,507.9 ns |   661,120.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,823.4 ns |  3,727.82 ns |   204.33 ns | 1,380,655.0 ns | 1,381,050.7 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,332.8 ns |  6,741.16 ns |   369.51 ns |   163,118.8 ns |   163,759.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,877.5 ns |  1,148.84 ns |    62.97 ns |    91,826.8 ns |    91,948.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,087.6 ns |  7,356.59 ns |   403.24 ns |    32,822.8 ns |    33,551.6 ns |      - |      40 B |
