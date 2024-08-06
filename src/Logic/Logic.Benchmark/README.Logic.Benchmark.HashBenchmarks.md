```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,323.9 ns** |     **83.19 ns** |     **4.56 ns** |     **1,319.2 ns** |     **1,328.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,484.8 ns |    358.57 ns |    19.65 ns |     1,472.0 ns |     1,507.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,696.5 ns |     54.48 ns |     2.99 ns |     1,693.2 ns |     1,699.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,707.5 ns |    782.39 ns |    42.89 ns |     2,681.7 ns |     2,757.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       207.8 ns |     45.26 ns |     2.48 ns |       206.0 ns |       210.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.5 ns |     17.66 ns |     0.97 ns |       285.9 ns |       287.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       485.6 ns |      6.49 ns |     0.36 ns |       485.2 ns |       485.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,750.3 ns** |  **6,290.62 ns** |   **344.81 ns** | **1,545,454.8 ns** | **1,546,129.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,349.6 ns |  1,600.91 ns |    87.75 ns |   614,255.3 ns |   614,428.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,246.6 ns | 34,525.92 ns | 1,892.48 ns |   656,004.7 ns |   659,424.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,572.2 ns |  9,926.40 ns |   544.10 ns | 1,372,944.0 ns | 1,373,892.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,314.4 ns |  2,708.30 ns |   148.45 ns |   162,211.2 ns |   162,484.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,404.1 ns |    312.39 ns |    17.12 ns |    91,384.8 ns |    91,417.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,254.2 ns |  7,789.67 ns |   426.98 ns |    65,003.9 ns |    65,747.2 ns |      - |      40 B |
