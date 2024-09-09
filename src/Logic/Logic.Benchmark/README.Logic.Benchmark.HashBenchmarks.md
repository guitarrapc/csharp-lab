```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,324.3 ns** |     **78.34 ns** |     **4.29 ns** |     **1,321.7 ns** |     **1,329.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,457.8 ns |     89.81 ns |     4.92 ns |     1,454.2 ns |     1,463.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,710.1 ns |    111.86 ns |     6.13 ns |     1,703.1 ns |     1,714.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,682.0 ns |    194.41 ns |    10.66 ns |     2,670.6 ns |     2,691.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.8 ns |      6.42 ns |     0.35 ns |       201.6 ns |       202.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       316.5 ns |     16.97 ns |     0.93 ns |       315.4 ns |       317.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       500.5 ns |     45.81 ns |     2.51 ns |       497.8 ns |       502.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,496.9 ns** |    **510.02 ns** |    **27.96 ns** | **1,545,472.5 ns** | **1,545,527.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   615,024.9 ns | 19,258.11 ns | 1,055.60 ns |   614,370.4 ns |   616,242.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,463.3 ns | 10,015.78 ns |   549.00 ns |   654,988.2 ns |   656,064.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,109.0 ns | 23,432.52 ns | 1,284.42 ns | 1,381,633.3 ns | 1,383,975.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,525.4 ns |  5,012.48 ns |   274.75 ns |   162,299.7 ns |   162,831.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,496.1 ns |  1,046.10 ns |    57.34 ns |    91,453.4 ns |    91,561.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,547.3 ns |  7,569.90 ns |   414.93 ns |    65,278.3 ns |    66,025.1 ns |      - |      40 B |
