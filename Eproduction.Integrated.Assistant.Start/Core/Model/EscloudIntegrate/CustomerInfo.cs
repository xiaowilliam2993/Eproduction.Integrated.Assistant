﻿namespace Eproduction.Integrated.Assistant.Start.Core {
    public class CustomerInfo {
        public CustomerType CustomerType { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerServiceCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerFullName { get; set; }
    }
    public enum CustomerType {
        YF,
        E10
    }
}
