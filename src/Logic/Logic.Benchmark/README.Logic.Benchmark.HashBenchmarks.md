```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,304.2 ns** |     **36.00 ns** |     **1.97 ns** |     **1,302.0 ns** |     **1,305.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,453.5 ns |      7.86 ns |     0.43 ns |     1,453.1 ns |     1,454.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,713.6 ns |    256.48 ns |    14.06 ns |     1,705.4 ns |     1,729.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,668.5 ns |    457.32 ns |    25.07 ns |     2,649.7 ns |     2,696.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.5 ns |     16.30 ns |     0.89 ns |       209.8 ns |       211.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.9 ns |      9.13 ns |     0.50 ns |       286.3 ns |       287.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.6 ns |     22.34 ns |     1.22 ns |       481.2 ns |       483.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,818.7 ns** |  **3,958.29 ns** |   **216.97 ns** | **1,545,672.4 ns** | **1,546,068.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,159.6 ns |  3,407.08 ns |   186.75 ns |   613,947.6 ns |   614,299.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,780.5 ns | 29,613.43 ns | 1,623.21 ns |   654,786.7 ns |   657,653.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,786.0 ns | 10,066.14 ns |   551.76 ns | 1,373,411.4 ns | 1,374,419.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,342.1 ns |  3,827.69 ns |   209.81 ns |   162,141.6 ns |   162,560.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,661.4 ns |  9,197.93 ns |   504.17 ns |    91,352.1 ns |    92,243.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,137.7 ns |  6,786.73 ns |   372.00 ns |    64,892.0 ns |    65,565.7 ns |      - |      40 B |
