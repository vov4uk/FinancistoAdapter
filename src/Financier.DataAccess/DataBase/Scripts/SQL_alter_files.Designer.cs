﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Financier.DataAccess.DataBase.Scripts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SQL_alter_files {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SQL_alter_files() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Financier.DataAccess.DataBase.Scripts.SQL_alter_files", typeof(SQL_alter_files).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO category (_id, title, left, right) VALUES (0, &apos;&lt;NO_CATEGORY&gt;&apos;, 1, 2);
        ///
        ///INSERT INTO project (_id, title) VALUES (0, &apos;&lt;NO_PROJECT&gt;&apos;);
        ///
        ///INSERT INTO locations(_id, name, datetime, provider, accuracy, latitude, longitude, is_payee, resolved_address) 
        ///VALUES (0, &apos;&lt;CURRENT_LOCATION&gt;&apos;, 0, &quot;?&quot;, &quot;?&quot;, 0, 0, 0, &quot;?&quot;);.
        /// </summary>
        internal static string _20090723_0035_initial_data {
            get {
                return ResourceManager.GetString("_20090723_0035_initial_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE currency ADD COLUMN is_default integer not null default 0;.
        /// </summary>
        internal static string _20090830_1754_add_is_default {
            get {
                return ResourceManager.GetString("_20090830_1754_add_is_default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE currency ADD COLUMN decimals integer not null default 2;.
        /// </summary>
        internal static string _20090929_2217_add_decimals {
            get {
                return ResourceManager.GetString("_20090929_2217_add_decimals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN type text not null default &apos;CASH&apos;;
        ///ALTER TABLE account ADD COLUMN issuer text;
        ///ALTER TABLE account ADD COLUMN number text;.
        /// </summary>
        internal static string _20091010_1709_add_types_to_account {
            get {
                return ResourceManager.GetString("_20091010_1709_add_types_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN sort_order integer not null default 0;.
        /// </summary>
        internal static string _20091014_2319_add_sort_order_to_account {
            get {
                return ResourceManager.GetString("_20091014_2319_add_sort_order_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN is_active boolean not null default 1;.
        /// </summary>
        internal static string _20091026_1456_add_is_active_to_account {
            get {
                return ResourceManager.GetString("_20091026_1456_add_is_active_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE currency ADD COLUMN decimal_separator text;
        ///ALTER TABLE currency ADD COLUMN group_separator text;.
        /// </summary>
        internal static string _20091110_2228_add_more_params_to_currency {
            get {
                return ResourceManager.GetString("_20091110_2228_add_more_params_to_currency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN is_include_into_totals boolean not null default 1;.
        /// </summary>
        internal static string _20091121_0104_add_is_included_into_totals_to_account {
            get {
                return ResourceManager.GetString("_20091121_0104_add_is_included_into_totals_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE locations ADD COLUMN count integer not null default 0;.
        /// </summary>
        internal static string _20091124_1721_add_count_to_location {
            get {
                return ResourceManager.GetString("_20091124_1721_add_count_to_location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to REPLACE INTO locations(_id,name,datetime,provider,accuracy,latitude,longitude,is_payee,resolved_address,count) 
        ///select l._id,l.name,l.datetime,l.provider,l.accuracy,l.latitude,l.longitude,l.is_payee,l.resolved_address,count(*) 
        ///from transactions t inner join locations l where t.location_id=l._id group by l._id;.
        /// </summary>
        internal static string _20091124_1824_update_count_for_locations {
            get {
                return ResourceManager.GetString("_20091124_1824_update_count_for_locations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to REPLACE INTO locations(_id,name,datetime,provider,accuracy,latitude,longitude,is_payee,resolved_address,count) 
        ///select l._id,l.name,l.datetime,l.provider,l.accuracy,l.latitude,l.longitude,l.is_payee,l.resolved_address,count(*) 
        ///from transactions t inner join locations l where t.location_id=l._id group by l._id;.
        /// </summary>
        internal static string _20091125_2310_update_count_for_locations {
            get {
                return ResourceManager.GetString("_20091125_2310_update_count_for_locations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN last_category_id long not null default 0;
        ///
        ///ALTER TABLE category ADD COLUMN last_location_id long not null default 0;
        ///
        ///ALTER TABLE category ADD COLUMN last_project_id long not null default 0;.
        /// </summary>
        internal static string _20091126_2208_add_remember_fields {
            get {
                return ResourceManager.GetString("_20091126_2208_add_remember_fields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN payee text;.
        /// </summary>
        internal static string _20091127_2106_add_payee_to_transaction {
            get {
                return ResourceManager.GetString("_20091127_2106_add_payee_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN last_account_id long not null default 0;.
        /// </summary>
        internal static string _20091128_1302_add_last_account_id_to_account {
            get {
                return ResourceManager.GetString("_20091128_1302_add_last_account_id_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN total_limit integer not null default 0;.
        /// </summary>
        internal static string _20091128_1748_add_limit_to_account {
            get {
                return ResourceManager.GetString("_20091128_1748_add_limit_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE category ADD COLUMN sort_order integer not null default 0;.
        /// </summary>
        internal static string _20091130_2236_add_sort_order_to_category {
            get {
                return ResourceManager.GetString("_20091130_2236_add_sort_order_to_category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE budget ADD COLUMN recur text;
        ///
        ///ALTER TABLE budget ADD COLUMN recur_num integer not null default 0;
        ///
        ///ALTER TABLE budget ADD COLUMN is_current integer not null default 1;
        ///
        ///ALTER TABLE budget ADD COLUMN parent_budget_id long not null default 0;.
        /// </summary>
        internal static string _20091210_2339_add_recur_to_budget {
            get {
                return ResourceManager.GetString("_20091210_2339_add_recur_to_budget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE budget SET start_date=0 where start_date is null;
        ///
        ///UPDATE budget SET end_date=strftime(&apos;%s&apos;,datetime(&apos;now&apos;,&apos;start of year&apos;,&apos;+10 years&apos;,&apos;-1 second&apos;))||&apos;999&apos; where end_date is null;
        ///
        ///UPDATE budget SET recur = &apos;NO_RECUR,startDate=&apos;||start_date||&apos;,period=STOPS_ON_DATE,periodParam=&apos;||end_date;.
        /// </summary>
        internal static string _20091224_2250_alter_recur_for_existing_budgets {
            get {
                return ResourceManager.GetString("_20091224_2250_alter_recur_for_existing_budgets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists currency_rate (
        ///	from_currency_id integer not null,
        ///	to_currency_id integer not null,
        ///	rate double not null,
        ///	effective_date long not null
        ///);
        ///	
        ///.
        /// </summary>
        internal static string _20091228_0048_create_currency_rate_table {
            get {
                return ResourceManager.GetString("_20091228_0048_create_currency_rate_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN card_issuer text;.
        /// </summary>
        internal static string _20100114_1153_add_credit_card_type_to_account {
            get {
                return ResourceManager.GetString("_20100114_1153_add_credit_card_type_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE account SET card_issuer=type where type in (&apos;VISA&apos;,&apos;VISA_ELECTRON&apos;,&apos;MASTERCARD&apos;,&apos;MAESTRO&apos;,&apos;AMEX&apos;);
        ///UPDATE account SET type=&apos;DEBIT_CARD&apos; where type in (&apos;VISA&apos;,&apos;VISA_ELECTRON&apos;,&apos;MASTERCARD&apos;,&apos;MAESTRO&apos;,&apos;AMEX&apos;);
        ///.
        /// </summary>
        internal static string _20100114_1158_alter_accounts_types {
            get {
                return ResourceManager.GetString("_20100114_1158_alter_accounts_types", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE category SET sort_order=left;.
        /// </summary>
        internal static string _20100115_0003_update_sort_order_for_all_categories {
            get {
                return ResourceManager.GetString("_20100115_0003_update_sort_order_for_all_categories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE budget ADD COLUMN project_id text;.
        /// </summary>
        internal static string _20100320_2045_add_project_to_budget {
            get {
                return ResourceManager.GetString("_20100320_2045_add_project_to_budget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE budget ADD COLUMN expanded integer not null default 0;.
        /// </summary>
        internal static string _20100322_2041_add_expanded_to_budget {
            get {
                return ResourceManager.GetString("_20100322_2041_add_expanded_to_budget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN is_template integer not null default 0;
        ///
        ///CREATE INDEX IF NOT EXISTS idx_is_template ON transactions(is_template);.
        /// </summary>
        internal static string _20100410_1748_add_is_template_to_transaction {
            get {
                return ResourceManager.GetString("_20100410_1748_add_is_template_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN template_name text;.
        /// </summary>
        internal static string _20100416_2329_add_template_name_to_transaction {
            get {
                return ResourceManager.GetString("_20100416_2329_add_template_name_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN recurrence text;.
        /// </summary>
        internal static string _20100427_2208_add_recurrence_to_transaction {
            get {
                return ResourceManager.GetString("_20100427_2208_add_recurrence_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN notification_options text;.
        /// </summary>
        internal static string _20100504_0020_add_notification_options_to_transaction {
            get {
                return ResourceManager.GetString("_20100504_0020_add_notification_options_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN status text not null default &apos;UR&apos;;.
        /// </summary>
        internal static string _20100506_2129_add_status_to_transaction {
            get {
                return ResourceManager.GetString("_20100506_2129_add_status_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO attributes (_id, type, name, list_values, default_value)
        ///VALUES (-1, 4, &apos;DELETE_AFTER_EXPIRED&apos;, null, &apos;true&apos;);.
        /// </summary>
        internal static string _20100511_2253_add_delete_after_expired_attribute {
            get {
                return ResourceManager.GetString("_20100511_2253_add_delete_after_expired_attribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE budget ADD COLUMN include_credit integer not null default 1;.
        /// </summary>
        internal static string _20100522_1311_add_include_credit_to_budget {
            get {
                return ResourceManager.GetString("_20100522_1311_add_include_credit_to_budget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN attached_picture text;.
        /// </summary>
        internal static string _20100617_2118_add_picture_to_transaction {
            get {
                return ResourceManager.GetString("_20100617_2118_add_picture_to_transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN closing_day integer not null default 0;
        ///ALTER TABLE account ADD COLUMN payment_day integer not null default 0;
        ///ALTER TABLE transactions ADD COLUMN is_ccard_payment integer not null default 0;.
        /// </summary>
        internal static string _20100721_0737_add_bill_filtering_pars_to_account {
            get {
                return ResourceManager.GetString("_20100721_0737_add_bill_filtering_pars_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN last_recurrence long not null default 0;.
        /// </summary>
        internal static string _20100927_2135_add_last_recurrence_to_transactions {
            get {
                return ResourceManager.GetString("_20100927_2135_add_last_recurrence_to_transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists payee (
        ///	_id integer primary key autoincrement,
        ///	title text
        ///);.
        /// </summary>
        internal static string _20101115_2200_add_payee_table {
            get {
                return ResourceManager.GetString("_20101115_2200_add_payee_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN payee_id long;.
        /// </summary>
        internal static string _20101118_2001_add_payee_id_to_transactions {
            get {
                return ResourceManager.GetString("_20101118_2001_add_payee_id_to_transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE category ADD COLUMN type integer not null default 0;
        ///.
        /// </summary>
        internal static string _20101216_0152_add_type_to_category {
            get {
                return ResourceManager.GetString("_20101216_0152_add_type_to_category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists ccard_closing_date (
        ///	account_id long not null,
        ///	period integer not null,
        ///	closing_day integer not null
        ///);.
        /// </summary>
        internal static string _20110227_2112_add_ccard_closing_date {
            get {
                return ResourceManager.GetString("_20110227_2112_add_ccard_closing_date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists running_balance (
        ///	account_id integer not null,
        ///	transaction_id integer not null,
        ///	datetime long not null,
        ///	balance integer not null,
        ///	PRIMARY KEY (account_id, transaction_id)
        ///);
        ///
        ///create index if not exists running_balance_act_idx ON running_balance (account_id);
        ///
        ///create index if not exists running_balance_txn_idx ON running_balance (transaction_id);
        ///
        ///create index if not exists running_balance_dt_idx ON running_balance (datetime);
        ///.
        /// </summary>
        internal static string _20110412_0024_create_running_balance_table {
            get {
                return ResourceManager.GetString("_20110412_0024_create_running_balance_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO category (_id, title, left, right) VALUES (-1, &apos;&lt;SPLIT_CATEGORY&gt;&apos;, 0, 0);.
        /// </summary>
        internal static string _20110420_2316_add_split_category {
            get {
                return ResourceManager.GetString("_20110420_2316_add_split_category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists split (
        ///	_id integer primary key autoincrement,
        ///	transaction_id integer not null,
        ///	category_id integer not null,
        ///	amount integer not null,
        ///	note text
        ///);
        ///
        ///create index if not exists split_txn_idx ON split (transaction_id);
        ///
        ///create index if not exists split_cat_idx ON split (category_id);.
        /// </summary>
        internal static string _20110422_0051_create_split_table {
            get {
                return ResourceManager.GetString("_20110422_0051_create_split_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN parent_id long not null default 0;
        ///
        ///create index if not exists transaction_pid_idx ON transactions (parent_id);.
        /// </summary>
        internal static string _20110429_2323_add_parent_id_to_transactions {
            get {
                return ResourceManager.GetString("_20110429_2323_add_parent_id_to_transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update transactions set is_template=1 where parent_id in (select _id from transactions where parent_id=0 and is_template=1);
        ///update transactions set is_template=2 where parent_id in (select _id from transactions where parent_id=0 and is_template=2);.
        /// </summary>
        internal static string _20110903_0129_alter_template_splits {
            get {
                return ResourceManager.GetString("_20110903_0129_alter_template_splits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE payee ADD COLUMN last_category_id long not null default 0;.
        /// </summary>
        internal static string _20111124_2133_add_last_category_id_to_payee {
            get {
                return ResourceManager.GetString("_20111124_2133_add_last_category_id_to_payee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE currency ADD COLUMN symbol_format text not null default &apos;RS&apos;;.
        /// </summary>
        internal static string _20111127_1941_add_symbol_format_to_currency {
            get {
                return ResourceManager.GetString("_20111127_1941_add_symbol_format_to_currency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN note text;.
        /// </summary>
        internal static string _20111215_2017_add_note_to_account {
            get {
                return ResourceManager.GetString("_20111215_2017_add_note_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists currency_exchange_rate (
        ///	from_currency_id integer not null,
        ///	to_currency_id integer not null,
        ///	rate_date long not null,
        ///	rate float not null,
        ///	PRIMARY KEY (from_currency_id, to_currency_id, rate_date)
        ///);.
        /// </summary>
        internal static string _20120117_20581_create_currency_exchange_rate_table {
            get {
                return ResourceManager.GetString("_20120117_20581_create_currency_exchange_rate_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE project ADD COLUMN is_active boolean not null default 1;.
        /// </summary>
        internal static string _20120423_alter_projects_add_is_active {
            get {
                return ResourceManager.GetString("_20120423_alter_projects_add_is_active", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE account ADD COLUMN last_transaction_date long not null default 0;.
        /// </summary>
        internal static string _20120709_1956_add_last_transaction_date_to_account {
            get {
                return ResourceManager.GetString("_20120709_1956_add_last_transaction_date_to_account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE project ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE project ADD COLUMN remote_key text;
        ///
        ///ALTER TABLE payee ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE payee ADD COLUMN remote_key text;
        ///
        ///ALTER TABLE category ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE category ADD COLUMN remote_key text;
        ///
        ///ALTER TABLE account ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE account ADD COLUMN remote_key text;
        ///
        ///ALTER TABLE transactions ADD COLUMN updated_on TIMESTAMP DEFAULT 0 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _20120820_1725_add_needed_for_sync {
            get {
                return ResourceManager.GetString("_20120820_1725_add_needed_for_sync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN original_currency_id long not null default 0;.
        /// </summary>
        internal static string _20120904_1420_add_original_currency_and_amount_to_transactions {
            get {
                return ResourceManager.GetString("_20120904_1420_add_original_currency_and_amount_to_transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN original_from_amount long not null default 0;.
        /// </summary>
        internal static string _20120906_0128_add_original_currency_and_amount_to_transactions {
            get {
                return ResourceManager.GetString("_20120906_0128_add_original_currency_and_amount_to_transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE attributes ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE attributes ADD COLUMN remote_key text;
        ///.
        /// </summary>
        internal static string _20130624_1725_add_needed_for_sync_attributes {
            get {
                return ResourceManager.GetString("_20130624_1725_add_needed_for_sync_attributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE budget ADD COLUMN budget_account_id long;
        ///ALTER TABLE budget ADD COLUMN budget_currency_id long;
        ///
        ///UPDATE budget SET budget_currency_id = currency_id;.
        /// </summary>
        internal static string _20130704_2309_add_account_id_to_budget {
            get {
                return ResourceManager.GetString("_20130704_2309_add_account_id_to_budget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE transactions ADD COLUMN blob_key text;
        ///.
        /// </summary>
        internal static string _20130919_1725_add_needed_for_sync_blob {
            get {
                return ResourceManager.GetString("_20130919_1725_add_needed_for_sync_blob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///CREATE INDEX idx_key_act ON account (remote_key);
        ///CREATE INDEX idx_key_cat ON category (remote_key);
        ///CREATE INDEX idx_key_pro ON project (remote_key);
        ///CREATE INDEX idx_key_payee ON payee (remote_key);
        ///CREATE INDEX idx_key_cur ON currency (remote_key);
        ///CREATE INDEX idx_key_loc ON LOCATIONS (remote_key);
        ///.
        /// </summary>
        internal static string _20131226_1725_add_index_for_flowzr {
            get {
                return ResourceManager.GetString("_20131226_1725_add_index_for_flowzr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE locations ADD COLUMN title text;
        ///
        ///.
        /// </summary>
        internal static string _20160426_2152_add_title_to_locations {
            get {
                return ResourceManager.GetString("_20160426_2152_add_title_to_locations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE locations SET title = name;.
        /// </summary>
        internal static string _20160426_2205_update_locations {
            get {
                return ResourceManager.GetString("_20160426_2205_update_locations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists sms_template (
        ///	_id integer primary key autoincrement,
        ///	title text not null,
        ///	template text not null,
        ///	category_id integer not null,
        ///	account_id integer
        ///);
        ///
        ///create index if not exists smstemplate_num_idx ON sms_template (title);.
        /// </summary>
        internal static string _20171020_0707_add_sms_templates {
            get {
                return ResourceManager.GetString("_20171020_0707_add_sms_templates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE sms_template ADD COLUMN updated_on TIMESTAMP DEFAULT 0;
        ///ALTER TABLE sms_template ADD COLUMN remote_key text;.
        /// </summary>
        internal static string _20171028_0707_added_required_columns_to_smstemplates {
            get {
                return ResourceManager.GetString("_20171028_0707_added_required_columns_to_smstemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE sms_template ADD COLUMN is_income BOOLEAN not null default 0;.
        /// </summary>
        internal static string _20171207_0707_added_income_column_to_smstemplates {
            get {
                return ResourceManager.GetString("_20171207_0707_added_income_column_to_smstemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE account SET type=&apos;ELECTRONIC&apos;, card_issuer=&apos;PAYPAL&apos; where type=&apos;PAYPAL&apos;;
        ///.
        /// </summary>
        internal static string _20171230_1852_alter_electronic_account_type {
            get {
                return ResourceManager.GetString("_20171230_1852_alter_electronic_account_type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to create table if not exists attributes_t (
        ///	_id integer primary key autoincrement,
        ///	type integer not null default 1,
        ///	title text,
        ///	list_values text,
        ///	default_value text
        ///);
        ///
        ///INSERT INTO attributes_t (_id, type, title, list_values, default_value)
        ///   SELECT _id, type, name, list_values, default_value FROM attributes;
        ///
        ///DROP TABLE attributes;
        ///
        ///ALTER TABLE attributes_t RENAME TO attributes;
        ///
        ///.
        /// </summary>
        internal static string _20180117_1235_add_title_to_attributes {
            get {
                return ResourceManager.GetString("_20180117_1235_add_title_to_attributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE sms_template ADD COLUMN sort_order integer not null default 0;
        ///update sms_template set sort_order=_id;.
        /// </summary>
        internal static string _20180301_0101_added_order_column_to_smstemplates {
            get {
                return ResourceManager.GetString("_20180301_0101_added_order_column_to_smstemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE project ADD COLUMN sort_order integer not null default 0;
        ///update project set sort_order=_id;
        ///
        ///ALTER TABLE payee ADD COLUMN sort_order integer not null default 0;
        ///update payee set sort_order=_id;
        ///
        ///ALTER TABLE currency ADD COLUMN sort_order integer not null default 0;
        ///update currency set sort_order=_id;
        ///
        ///ALTER TABLE budget ADD COLUMN sort_order integer not null default 0;
        ///update budget set sort_order=_id;
        ///
        ///ALTER TABLE LOCATIONS ADD COLUMN sort_order integer not null default 0;
        ///update LOCATIONS set [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _20180301_0202_add_sort_order_to_all_entities {
            get {
                return ResourceManager.GetString("_20180301_0202_add_sort_order_to_all_entities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE payee ADD COLUMN is_active boolean not null default 1;
        ///ALTER TABLE locations ADD COLUMN is_active boolean not null default 1;
        ///ALTER TABLE attributes ADD COLUMN is_active boolean not null default 1;
        ///ALTER TABLE category ADD COLUMN is_active boolean not null default 1;
        ///ALTER TABLE currency ADD COLUMN is_active boolean not null default 1;
        ///ALTER TABLE sms_template ADD COLUMN is_active boolean not null default 1;.
        /// </summary>
        internal static string _20190209_alter_entities_add_is_active {
            get {
                return ResourceManager.GetString("_20190209_alter_entities_add_is_active", resourceCulture);
            }
        }
    }
}
