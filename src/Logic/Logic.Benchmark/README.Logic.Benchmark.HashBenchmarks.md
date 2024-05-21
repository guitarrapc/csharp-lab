```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,319.1 ns** |    **260.60 ns** |    **14.28 ns** |     **1,308.8 ns** |     **1,335.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,456.6 ns |    380.75 ns |    20.87 ns |     1,443.8 ns |     1,480.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,717.5 ns |     31.25 ns |     1.71 ns |     1,716.5 ns |     1,719.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,754.5 ns |    181.97 ns |     9.97 ns |     2,745.5 ns |     2,765.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.0 ns |     20.60 ns |     1.13 ns |       199.7 ns |       201.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.3 ns |     32.07 ns |     1.76 ns |       284.7 ns |       288.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       497.4 ns |      5.70 ns |     0.31 ns |       497.1 ns |       497.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,188.5 ns** |  **2,937.08 ns** |   **160.99 ns** | **1,545,049.0 ns** | **1,545,364.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   613,982.9 ns |  1,241.49 ns |    68.05 ns |   613,911.8 ns |   614,047.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,975.4 ns | 21,597.41 ns | 1,183.83 ns |   654,828.1 ns |   657,192.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,725.6 ns |  6,278.83 ns |   344.16 ns | 1,372,337.4 ns | 1,372,993.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,230.6 ns |  1,398.94 ns |    76.68 ns |   162,147.3 ns |   162,298.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,370.9 ns |    195.89 ns |    10.74 ns |    91,364.3 ns |    91,383.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,343.6 ns | 12,059.63 ns |   661.03 ns |    64,928.4 ns |    66,105.9 ns |      - |      40 B |
