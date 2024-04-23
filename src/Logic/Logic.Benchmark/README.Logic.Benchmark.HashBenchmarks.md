```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,314.1 ns** |     **88.48 ns** |     **4.85 ns** |     **1,310.9 ns** |     **1,319.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,456.2 ns |     59.61 ns |     3.27 ns |     1,452.6 ns |     1,459.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,704.3 ns |     63.82 ns |     3.50 ns |     1,701.1 ns |     1,708.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,678.0 ns |    172.41 ns |     9.45 ns |     2,667.6 ns |     2,685.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       198.9 ns |     23.43 ns |     1.28 ns |       197.6 ns |       200.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       282.5 ns |     29.98 ns |     1.64 ns |       281.3 ns |       284.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       445.3 ns |     42.34 ns |     2.32 ns |       443.5 ns |       447.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,118.4 ns** |  **9,316.23 ns** |   **510.65 ns** | **1,545,724.8 ns** | **1,546,695.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,456.1 ns |  3,885.68 ns |   212.99 ns |   614,222.8 ns |   614,640.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,289.3 ns | 21,257.85 ns | 1,165.21 ns |   655,022.5 ns |   657,315.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,837.7 ns | 14,808.11 ns |   811.68 ns | 1,372,940.5 ns | 1,374,521.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,572.8 ns | 39,476.15 ns | 2,163.82 ns |   162,232.4 ns |   166,069.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,491.3 ns |  4,156.72 ns |   227.84 ns |    91,338.2 ns |    91,753.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,436.8 ns |  4,794.53 ns |   262.80 ns |    65,261.0 ns |    65,738.9 ns |      - |      40 B |
