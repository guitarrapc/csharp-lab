```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,327.4 ns** |    **295.30 ns** |  **16.19 ns** |     **1,311.3 ns** |     **1,343.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,458.1 ns |    136.33 ns |   7.47 ns |     1,452.0 ns |     1,466.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,731.0 ns |    362.74 ns |  19.88 ns |     1,718.0 ns |     1,753.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,666.1 ns |     69.76 ns |   3.82 ns |     2,663.5 ns |     2,670.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       208.4 ns |    149.31 ns |   8.18 ns |       203.0 ns |       217.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.6 ns |     19.38 ns |   1.06 ns |       284.4 ns |       286.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       524.8 ns |     66.50 ns |   3.65 ns |       521.9 ns |       528.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,839.5 ns** |  **5,138.57 ns** | **281.66 ns** | **1,545,676.6 ns** | **1,546,164.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,154.5 ns |  1,439.71 ns |  78.92 ns |   614,091.1 ns |   614,242.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,728.0 ns | 15,030.17 ns | 823.85 ns |   655,040.3 ns |   656,641.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,076.4 ns | 16,515.28 ns | 905.26 ns | 1,372,464.4 ns | 1,374,116.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,263.8 ns |  2,396.37 ns | 131.35 ns |   162,120.6 ns |   162,378.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,399.9 ns |    965.16 ns |  52.90 ns |    91,348.3 ns |    91,454.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,987.2 ns |  1,440.78 ns |  78.97 ns |    64,914.9 ns |    65,071.5 ns |      - |      40 B |
