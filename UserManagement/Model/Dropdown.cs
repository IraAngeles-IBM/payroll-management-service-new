﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Model
{
    public class DropdownIURequest
    {

        public string series_code { get; set; }

        public int dropdown_id { get; set; }

        public int dropdown_type_id { get; set; }

        public string dropdown_description { get; set; }

        public string created_by { get; set; }

        public bool active { get; set; }

    }

    public class DropdownIUResponse
    {

        public int dropdown_id { get; set; }

        public int dropdown_type_id { get; set; }

        public string dropdown_description { get; set; }

        public Guid created_by { get; set; }

        public bool active { get; set; }
    }

    public class DropdownRequest
    {

        public string dropdown_type_id { get; set; }

        public string dropdown_type { get; set; }
    }

    public class DropdownResponse
    {
        public int id { get; set; }
        public string string_id { get; set; }

        public string description { get; set; }

        public string type_description { get; set; }

        public int type_id { get; set; }

        public bool active { get; set; }

    }

    public class DropdownTypeResponse
    {
        public string id { get; set; }

        public string description { get; set; }



    }

    public class BranchViewResponse
    {


        public int branch_id { get; set; }
        public string encrypted_branch_id { get; set; }

        public string branch_name { get; set; }
    }

    public class CategoryResponse
    {
        public int category_id { get; set; }
        public string category_code { get; set; }
        public string encrypt_category_id { get; set; }
        public string category_name { get; set; }
        public string category_description { get; set; }
        public int access_level_id { get; set; }
        public int approval_level_id { get; set; }
        public int change_schedule_before { get; set; }
        public int change_schedule_after { get; set; }
        public int change_log_before { get; set; }
        public int change_log_after { get; set; }
        public int official_business_before { get; set; }
        public int official_business_after { get; set; }
        public int overtime_before { get; set; }
        public int overtime_after { get; set; }
        public int offset_before { get; set; }
        public int offset_after { get; set; }
        public bool allow_overtime { get; set; }
        public int holiday_based_id { get; set; }
        public bool enable_tardiness { get; set; }
        public bool fixed_salary { get; set; }
        public int basis_sss_deduction_id { get; set; }
        public int basis_philhealth_deduction_id { get; set; }
        public int basis_pagibig_deduction_id { get; set; }
        public int created_by { get; set; }
        public string date_created { get; set; }
        public bool active { get; set; }

    }
    
    public class PayrollContributionResponse
    {
        public int          employee_id                     { get; set; }
        public string       display_name                    { get; set; }
        public string       employee_code                   { get; set; }
        public int          government_type_id              { get; set; }
        public string       government_type                 { get; set; }
        public int          timing_id                       { get; set; }
        public string       timing                          { get; set; }
        public decimal      amount                          { get; set; }
        public bool         taxable_id                      { get; set; }
        public string       taxable                         { get; set; }
        public int          created_by                      { get; set; }
        public string       date_created                    { get; set; }
        public string       status                          { get; set; }
    }
}
